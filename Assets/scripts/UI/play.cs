using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class play : MonoBehaviour {

	public Text instructions;
	public GameObject overlay;
//	public GameObject nextOverlay;
	// Use this for initialization
	void Start () {

		//overlay = GameObject.Find ("OverlayII").GetComponents<GameObject> ();
		//Time.timeScale = 0;

		//instructions.text = "With each food swiped your counter will increment";
		//instructions.text = "Swipe the colored balls on your screen." + "\nEach ball will turn into a food group Item.";


	}


	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {

			//
			//			Time.timeScale = 1;
			//			Destroy (overlay);
			//
		}



	}


	public void onConfirm()
	{

		Destroy (overlay);
		Time.timeScale = 1;

		//GameObject i =Instantiate (nextOverlay, nextOverlay.transform.position, nextOverlay.transform.rotation);
		//i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);




		//Instantiate(
	}
}
