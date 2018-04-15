using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Next : MonoBehaviour {

	public Text title;
	public Text instructions;
	public Text nextslide;
	//public GameObject overlay;
	//public GameObject nextOverlay;
	public GameObject Overlay,sprite;
	public List <GameObject> img;
	public static int  press=0;
	GameObject i,j;
	int limitpress=4;

	//Game Object i,ov,fin;
	// Use this for initialization
	void Start () {

	//	Overlay = GetComponents<GameObject> ();

		Time.timeScale = 0;
//		i =Instantiate (Overlay[0], Overlay[0].transform.position, Overlay[0].transform.rotation);
//		i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);
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


	public void onNextPress()

	{
		 

	//GameObject	i =Instantiate (Overlay[press], Overlay[press].transform.position, Overlay[press].transform.rotation);
		//i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);

	}



	public void onConfirm()
	{


		press++;
	//	img.Remove (img [0]);
		Destroy (sprite);
		switch(press)
		{
		case 1:
			
			title.text = "Counter";
			instructions.text = "With each food swiped your counter will increment";
			i =Instantiate (img[1], img[1].transform.position, img[1].transform.rotation);
			i.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);

			break;
		case 2:
			img.Remove (img [1]);
			Destroy (i);

			title.text = "Play to win!";
			instructions.text = "Collect the proper amount \nin each food group to win!"+"\n"+"\n"+"                             Are you ready?";
			j =Instantiate (img[1], img[1].transform.position, img[1].transform.rotation);
			j.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);//nextslide.text = "NEXT";
			break;

		case 3:
			img.Remove (img [1]);
			Destroy (j);
			title.text = "Score";
			instructions.text = "Keep an eye on your score "+ PlayerPrefs.GetString("usrName",name) + "\n"+ "Have fun staying healthy!";
			nextslide.text = "Play!";
			break;

		}




		if (press == limitpress)
		{
			Destroy (Overlay);
			Time.timeScale = 1;
		}




			}


		


	}

