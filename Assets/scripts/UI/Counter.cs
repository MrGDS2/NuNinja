using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour {
	public Text UI;

	public Text score;
	//public Text countg;
	// Use this for initialization
	void Start () {

		//UI= new Text[UI.Length];
		
	}

	// Update is called once per frame
	void Update () {


		//for(int i=0;i<UI.Length;i++)
		UI.text = Food.instance.Counting ().ToString ();

		if(!UI.text.Equals("0"))
			score.text ="Score: " + (Food.instance.Counting ()*100).ToString ();
		//UI[2].text = Food.instance.Counting ().ToString ();
	}
}
