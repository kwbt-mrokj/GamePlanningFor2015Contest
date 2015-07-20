using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	CharacterController characterController;
	public float moveSpeed = 15f;

	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal")*3f,0,0);

		characterController.Move (direction * moveSpeed * Time.deltaTime);

	}
	/*void OnCollisionEnter( Collider hitCollider){
		GameObject	hitObject	= hitCollider.gameObject;
		
		
		if( null==hitObject.GetComponent<aitem>()) {
			
			return;
		}
		Destroy ( hitCollider.gameObject);
	}*/

}
