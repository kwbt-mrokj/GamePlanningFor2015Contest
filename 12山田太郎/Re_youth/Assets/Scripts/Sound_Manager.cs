using UnityEngine;
using System.Collections;

public class Sound_Manager : MonoBehaviour 
{
	private AudioSource audioSource;
	public AudioClip decision;
	public AudioClip decision_roud;
	public AudioClip cancel;

	// Use this for initialization
	void Start () 
	{
		audioSource        = gameObject.GetComponent<AudioSource>();
		audioSource.loop    = false;    
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	public void Decision()
	{
		audioSource.PlayOneShot(decision);   
	}

	public void Decision_roud()
	{
		audioSource.PlayOneShot(decision);   
	}

	public void Cancel()
	{
		audioSource.PlayOneShot(cancel);   
	}
}
