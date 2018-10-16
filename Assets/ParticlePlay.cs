using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour {

	public ParticleSystem part11;
	public ParticleSystem part12;
	public ParticleSystem part13;
	public ParticleSystem part14;
	public ParticleSystem part21;
	public ParticleSystem part22;
	public ParticleSystem part23;
	public ParticleSystem part31;
	public ParticleSystem part32;
	public ParticleSystem part33;
	public ParticleSystem part34;
	public ParticleSystem part35;
	public ParticleSystem part36;
	public ParticleSystem part37;
	public ParticleSystem part38;


	public int partIndex = 0;

	private void Start()
	{
		AllStop();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			AllStop();
			if (partIndex == 3)
			{
				partIndex = 0;
			}
			else {
				partIndex++;
			}

			switch (partIndex) {
				case 0:
					AllStop();
					break;
				case 1:
					part11.Play();
					part12.Play();
					part13.Play();
					part14.Play();
					break;
				case 2:
					part21.Play();
					part22.Play();
					part23.Play();
					break;
				case 3:
					part31.Play();
					part32.Play();
					part33.Play();
					part34.Play();
					part35.Play();
					part36.Play();
					part37.Play();
					part38.Play();
					break;
			}
		}
	}

	public void AllStop() {
		part11.Stop();
		part12.Stop();
		part13.Stop();
		part14.Stop();
		part21.Stop();
		part22.Stop();
		part23.Stop();
		part31.Stop();
		part32.Stop();
		part33.Stop();
		part34.Stop();
		part35.Stop();
		part36.Stop();
		part37.Stop();
		part38.Stop();
	}
}
