using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Status : MonoBehaviour {
	// ステータスの構造体
	public struct status 
	{
		public string name;
		public int maxHP;
		public int HP;
		public int bunkei;
		public int rikei;
		public int taiikukaikei;
	}
	public status player;
	public Text HaveTime;
	public Have_Time haveTime;
	void Start () 
	{
		haveTime = GameObject.Find("Have_Time").GetComponent<Have_Time>();
		//PlayerPrefs.SetInt ("haveTime", haveTime);
		//HaveTime.text = "所持時間 : " + haveTime;
	}
	// Update is called once per frame
	void Update () 
	{
		if(player.bunkei < 50)
		{
			
		}

		if(player.rikei < 50)
		{
			
		}

		if(player.taiikukaikei < 50)
		{
			
		}
	}

	public void Set_bunkei()
	{

			Debug.Log("bunkei");
			PlayerPrefs.SetInt ("bunkei", 10);
			haveTime.SubtractTime(10f);

	}

	public void Set_rikei()
	{
			PlayerPrefs.SetInt ("rikei", 10);
			haveTime.SubtractTime(10f);

	}

	public void Set_taiikukaikei()
	{

			PlayerPrefs.SetInt ("taiikukaikei", 10);
			haveTime.SubtractTime(10f);

	}
}
