using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Next : MonoBehaviour {

	public Text title;
	public Text instructions;
	public Text nextslide;
	public GameObject Overlay,sprite;
	public List <GameObject> img;
	public static int  press=0;
	GameObject i,j,k,l,n;
	int limitpress=6;

	// Use this for initialization
	void Start () {

		Time.timeScale = 0;
	

	}


	// Update is called once per frame
	void Update () {
		

	
	}


	public void onNextPress()

	{
		 


	}



	public void onConfirm()
	{


		press++; //counts pressed 'ok' button
		Debug.Log (press);
		Destroy (sprite);

		//changes overlay information 

		/* each item once shown is taken 
		 * out of the list and next one moves up*/
		switch(press)
		{
		case 1:
			
			title.text = "Counter";
			instructions.text = "With each food swiped your counter will \n increment.";
			i =Instantiate (img[0], img[0].transform.position, img[0].transform.rotation);
			i.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);

			break;
		case 2:
			img.Remove (img [0]);
			Destroy (i);

			title.text = "Play to win!";
			instructions.text = "Collect the proper amount of nutrients \nin each food group to win!"+"\n"+"\n"+"                             Are you ready?";
			j =Instantiate (img[0], img[0].transform.position, img[0].transform.rotation);
			j.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);//nextslide.text = "NEXT";
			break;

		case 3:
			img.Remove (img [0]);
			Destroy (j);
			title.text = "Score";
			instructions.text = "Keep an eye on your score "+ PlayerPrefs.GetString("usrName",name) + "\n"+ " It will go up with each item swiped\n Have fun staying healthy!";
			l =Instantiate (img[0], img[0].transform.position, img[0].transform.rotation);
			l.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);

		//	nextslide.text = "Play!";
			break;


		case 4:
			//last card view
			img.Remove (img [0]);
			Destroy (l);
			title.text = "watch out";
			instructions.text = "Look out for bad carbs! Hitting the purple \ncolored ball will result in a negative score.\nDon't let it disrupt your nutritional flow!";
			k =Instantiate (img[0], img[0].transform.position, img[0].transform.rotation);
			k.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);

			//nextslide.text = "Play!";
			break;


		case 5:
			//last card view
			img.Remove (img [0]);
			Destroy (k);
			title.text = "your goal";
			instructions.text = "Focus on the GREEN balls!\nLet's get 5 to complete the fruit group";
			n =Instantiate (img[0], img[0].transform.position, img[0].transform.rotation);
			n.transform.SetParent (GameObject.FindGameObjectWithTag ("Overlay").transform, false);

			nextslide.text = "Play!";
			break;

		}



		/*limit set to how many times usr can press ok 
		 * & view next slide==> until end**/
		if (press == limitpress)
		{
			Destroy (Overlay);
			Time.timeScale = 1;
		}




			}


		


	}

