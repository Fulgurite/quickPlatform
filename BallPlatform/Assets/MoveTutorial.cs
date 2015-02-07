using UnityEngine;
using System.Collections;

public class MoveTutorial : MonoBehaviour {
	
	public GameObject MoveMessage;
	public GameObject JumpMessage;
	
	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.name == "Char") {
			MoveMessage.SetActive(true);
			JumpMessage.SetActive(false);
		}
	}
}
