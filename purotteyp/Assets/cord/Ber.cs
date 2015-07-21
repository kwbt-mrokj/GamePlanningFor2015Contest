using UnityEngine;
using System.Collections;

public class Ber : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("boks").Length == 0) {
			
			Application.LoadLevel (Application.loadedLevel);
			
		}

	}
	void OnCollisionEnter(Collision other)
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
