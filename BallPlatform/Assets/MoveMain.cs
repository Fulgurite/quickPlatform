using UnityEngine;
using System.Collections;

public class MoveMain : MonoBehaviour {
	public float moveSpeed = 0.1f;
	public float jumpSpeed = 0.1f;
	
	float intervalPower = 0.5f;     // interval to add velocity
	float intervalCarry = 0.5f;     // interval to carry over jump
	private float timePower = 0f; // time to add velocity
	private float timeCarry = 0f; // time to carry over jump


		//   modify your jump control this way:
	//  if (Input.GetButtonDown("Jump") && Time.time > nextJump){
	//	  nextJump = Time.time + jumpInterval;
	  	  // here goes your current jump code
	//  }
	
	public bool falling = true;
	public bool grounded = false;
	
	public KeyCode right;
	public KeyCode left;
	public KeyCode up;
	
	// Update is called once per frame
	void FixedUpdate () {
		// up key pressed?
		if (Input.GetKeyDown (up) && grounded) {
			timePower = Time.time + intervalPower;
			grounded = false;
			timeCarry = Time.time + intervalCarry + intervalPower;
		} 
		if (Input.GetKeyUp (up) && Time.time < timePower) {
			timeCarry = Time.time + intervalCarry;
			timePower = Time.time;
		}

		if (Input.GetKey (up) && Time.time < timePower)
				transform.Translate (new Vector2 (0.0f, jumpSpeed));
		if (Time.time < timeCarry)
				transform.Translate (new Vector2 (0.0f, jumpSpeed));
		if (Time.time > timeCarry && grounded == false)
				falling = true;

		// right key pressed?
		if (Input.GetKey(right)) {
			transform.Translate(new Vector2(moveSpeed,0.0f));
		}
		// left key pressed?
		if (Input.GetKey(left)) {
			transform.Translate(new Vector2(-moveSpeed,0.0f));
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
			if (col.gameObject.tag == "Ground" && falling) {
				grounded = true;
				falling = false;
			}
	}
}