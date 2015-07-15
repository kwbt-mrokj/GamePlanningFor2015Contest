using UnityEngine;
using System.Collections;

public class Button_Manager : MonoBehaviour 
{
	public string nextScene;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Click_Back()
	{
		Application.LoadLevel (nextScene);
	}
}
