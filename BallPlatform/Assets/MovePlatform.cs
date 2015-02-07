using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(0.5f,0.0f).normalized * speed;
	}

	void OnCollisionEnter2D(Collision2D col) {
		
		// Hit the left Racket?
		if (col.gameObject.name == "WallLeft") {
			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(1.0f, 0.0f).normalized;
			
			// Set Velocity with dir * speed
			rigidbody2D.velocity = dir * speed;
		}
		
		// Hit the right Racket?
		if (col.gameObject.name == "WallRight") {
			
			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(-1.0f, 0.0f).normalized;
			
			// Set Velocity with dir * speed
			rigidbody2D.velocity = dir * speed;
		}
	}
}
