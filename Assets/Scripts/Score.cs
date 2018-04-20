using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	public Text te;
	static int score;
	// Use this for initialization
	void Start () {
		
		te.text = score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void insc()
	{
		score += 1;
		te.text = score.ToString ();
	}

	public void setZero()
	{
		score = 0;
	}
}
