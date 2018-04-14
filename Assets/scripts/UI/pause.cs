using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pause : MonoBehaviour {
	public Text instructions;
	public GameObject overlay;
	// Use this for initialization
	void Start () {
		instructions.text = "Swipe the colored balls on your screen." + "\nEach ball will turn into a food group Item.";
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
         

			Time.timeScale = 1;
			Destroy (overlay);

		}


	}

}
