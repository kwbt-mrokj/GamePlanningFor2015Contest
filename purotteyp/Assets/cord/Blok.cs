using UnityEngine;
using System.Collections;

public class Blok : MonoBehaviour {
	public GameObject aitem;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
		Instantiate (this.aitem, new Vector3 (0, 0, 0), Quaternion.identity);
	}
}

