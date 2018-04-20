using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadGame : MonoBehaviour {
	Score s;
	// Use this for initialization
	void Start () {
		s = GameObject.Find ("Canvas").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart()
	{
		s.SendMessage ("setZero");
		Application.LoadLevel ("1");
	}
}
