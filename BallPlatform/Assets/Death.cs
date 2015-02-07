using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public AudioClip Hurt;

	private AudioSource source;

	public float hurtVol = 1.0f;
	private float lowPitchRange = .75F;
	private float highPitchRange = 1.5F;
	private float velToVol = .2F;

	void Awake () {
		
		source = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D col) {
		source.pitch = Random.Range (lowPitchRange,highPitchRange);
		//float hurtVol = col.relativeVelocity.magnitude * velToVol;
		source.PlayOneShot(Hurt,hurtVol);
	}
}
