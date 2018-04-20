using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawnner : MonoBehaviour {

	public Transform[] spikeSpawns;
	public GameObject spike;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn()
	{
		for (int i = 0 ; i < spikeSpawns.Length ; i++) {

			int spikeFlip = Random.Range(0,2);

			if (spikeFlip > 0) {
				Instantiate (spike, spikeSpawns [i].position, Quaternion.identity);
			}
		}	
	}
		
}
