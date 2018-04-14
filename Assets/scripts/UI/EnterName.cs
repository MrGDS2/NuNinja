using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnterName : MonoBehaviour {
	[SerializeField]
	private InputField input;

	public void GetInput(string name)
	{  print ("You Entered" + name);
		input.text = "";
		PlayerPrefs.SetString ("usrName", name);
	}




	void Awake()
	{
		
	}
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
