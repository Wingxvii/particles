using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour {

	public List<ParticleSystem> part1;
	public List<ParticleSystem> part2;
	public List<ParticleSystem> part3;

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
					foreach (ParticleSystem part in part1)
					{
						part.Play();
					}
					break;
				case 2:
					foreach (ParticleSystem part in part2)
					{
						part.Play();
					}
					break;
				case 3:
					foreach (ParticleSystem part in part3)
					{
						part.Play();
					}
					break;
			}
		}
	}

	public void AllStop() {
		foreach (ParticleSystem part in part1) {
			part.Stop();
		}
		foreach (ParticleSystem part in part2)
		{
			part.Stop();
		}
		foreach (ParticleSystem part in part3)
		{
			part.Stop();
		}

	}
}
