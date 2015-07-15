using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Have_Time : MonoBehaviour {
	
	public float haveTime;
	
	void Start () 
	{
		PlayerPrefs.GetFloat ("Time");
	}
	
	public void AddTime (float addTime) {
		haveTime += addTime;
		PlayerPrefs.SetFloat ("Time", haveTime);
	}
	
	public void SubtractTime (float subTime){
		haveTime -= subTime;
		PlayerPrefs.SetFloat ("Time", haveTime);
	}
	
	void OnGUI () {
		GUI.Label(new Rect(10,10,30000,30000),"所持時間 : " + haveTime);
	}
}
