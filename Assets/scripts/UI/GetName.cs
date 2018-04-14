using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetName : MonoBehaviour {

	public Text display;
	// Use this for initialization
	void Start () {

		//display = GetComponents<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		display.text = "  "+
			PlayerPrefs.
			GetString ("usrName",name) +
			",\n" +"\n" + 
			"choose your" +"\n " +
			"   " +"\n \tsex";
	}
}
