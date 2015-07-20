using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private float kakudo_x;
	private float kakudo_y;
	private float kakudo;
	// Use this for initialization
	void Start () {
		kakudo_x = Random.Range (10.0f, 70.0f);
		kakudo_y = Random.Range (10.0f, 70.0f);
		kakudo = Random.Range (0.0f, 9.0f);
		if (kakudo > 4) 
		{
			kakudo_x *= -1;
		}

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetButtonDown ("Submit")&& kakudo_x!=0 )
		{
		GetComponent<Rigidbody> ().velocity = new Vector3(kakudo_x,kakudo_y,0);
			kakudo_x = 0;
		 }
	}
	void OnCollisionEnter(Collision other)
	{
			GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody> ().velocity.normalized * 15;

		/*if ( GetComponent<Rigidbody> ().velocity.y > 3f)
		{
			GetComponent<Rigidbody> ().velocity.y *= 5f;
		}*/
	}
	/*void OnTriggerEnter(Collider other)
	{
		if (other.tag = "out") 
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}*/
}
    