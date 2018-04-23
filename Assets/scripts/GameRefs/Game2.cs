using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game2 : MonoBehaviour {

	// Use this for initialization
	public List<Text> trackitem;
	public List<GameObject> goalOverlay;
	public GameObject O;
	GameObject i,ii;
	public static int press=0;
	int limitpress=1;
	int rstint=0;
	string rst="0";

	Color goal=new Color32(0x33,0xFF,0x00,0xFF);


	bool isCreated=false;



	void Start () {
	//	trackitem.Add (Counter.instance.fScore);
		//reset count
		Counter.instance.pScore.text = "0";
		Counter.pAmount = 0;
		Counter.instance.dScore.text = "0";
		Counter.dAmount = 0;
		Counter.instance.veggie.text = "0";
		Counter.vAmount = 0;
		Counter.instance.gScore.text = "0";
		Counter.gAmount = 0;
		Counter.instance.fScore.text = "0";
		Counter.fAmount = 0;


		Time.timeScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		Gametracker(0);
	}



	public void onConfirm()
	{


		press++; //counts pressed 'ok' button

		/*limit set to how many times usr can press ok 
		 * & view next slide==> until end**/
		if(O!=null)
		Destroy (O);


	}
		

	void Gametracker(int j)
	{



		if (Counter.pAmount==1 && !isCreated) {
			trackitem [j].color = goal;
			Time.timeScale = 0; //pause game for overlay screen
			i = Instantiate (goalOverlay [j], goalOverlay [j].transform.position, goalOverlay [j].transform.rotation);
			i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);
			isCreated = true;
		
		}


		if (press == limitpress) {
			Destroy (i);  
			Time.timeScale = 1;

			press = 0;

			Debug.Log ("destroyed and reset press count");

		}
	}


	Color Colorset(Color col)
	{

		return 	Counter.instance.fScore.color = col;

			}

}
