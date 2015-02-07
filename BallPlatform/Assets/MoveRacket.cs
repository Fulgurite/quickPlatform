using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {
	public KeyCode up;
	public KeyCode down;
	public KeyCode right;
	public KeyCode left;


	// Update is called once per something
	void FixedUpdate () {
		// up key pressed?
		if (Input.GetKey(up)) {
			transform.Translate(new Vector2(0.0f,0.1f));
		}
		
		// down key pressed?
		if (Input.GetKey(down)) {
			transform.Translate(new Vector2(0.0f,-0.1f));
		}
		
		// right key pressed?
		if (Input.GetKey(right)) {
			transform.Translate(new Vector2(0.1f,0.0f));
		}

		// left key pressed?
		if (Input.GetKey(left)) {
			transform.Translate(new Vector2(-0.1f,0.0f));
		}
	}
}
