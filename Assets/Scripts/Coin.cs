using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	Score s;

	// Use this for initialization
	void Start () {
		s = GameObject.Find ("Canvas").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			s.SendMessage ("insc");
			Destroy (gameObject);
		}
	}
}
