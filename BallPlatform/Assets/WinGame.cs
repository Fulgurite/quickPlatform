using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {

	public GameObject WinMessage;

	public AudioClip crowdCheer;
	
	private AudioSource source;
	
	public float crowdVol = 1.0f;
	private float lowPitchRange = .75F;
	private float highPitchRange = 1.5F;

	
	void Awake () {
		
		source = GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter2D(Collision2D col) {
		if (WinMessage.activeSelf == false) {
			WinMessage.SetActive(true);
			source.pitch = Random.Range (lowPitchRange,highPitchRange);
			source.PlayOneShot(crowdCheer,crowdVol);
		}
	}
}
