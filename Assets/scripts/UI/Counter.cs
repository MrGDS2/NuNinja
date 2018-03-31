using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour {
	public Text UI,UII;

	public Text score;
	//public Text countg;
	// Use this for initialization
	void Start () {

		//UI= new Text[UI.Length];
		
	}

	// Update is called once per frame
	void Update () {
		



		UI.text =(Food.instance.f["grain"]).ToString();
		UII.text =  "4";
	//	if(!UI.text.Equals("0"))
 // 	score.text ="Score: " + (Food.instance.Counting ()*100).ToString ();
		
	}
}
