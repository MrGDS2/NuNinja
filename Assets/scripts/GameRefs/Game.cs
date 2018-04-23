using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {

	// Use this for initialization
	public List<Text> trackitem;
	public List<GameObject> goalOverlay;
	GameObject i,ii;
	public static int press=0;
	int limitpress=1;
	int rstint=0;
	string rst="0";

	Color goal=new Color32(0x33,0xFF,0x00,0xFF);


	bool isCreated=false;



	void Start () {
	//	trackitem.Add (Counter.instance.fScore);


	
	}
	
	// Update is called once per frame
	void Update () {

	
	//	Debug.Log("game" + trackitem[0].text);
		Gametracker(0,"1");

//		if (Counter.vAmount == 1) {
//			Gametracker (1, "1");
//		}





	}



	public void onConfirm()
	{


		press++; //counts pressed 'ok' button

		/*limit set to how many times usr can press ok 
		 * & view next slide==> until end**/

		if (press == limitpress)
		{
			//goalOverlay.Remove(goalOverlay [0]);

			Debug.Log ("pressed");

		
		}

	}
		

	void Gametracker(int j,string g)
	{



		if (Counter.fAmount==1 && !isCreated) {
			trackitem [j].color = goal;
			Time.timeScale = 0; //pause game for overlay screen
			i = Instantiate (goalOverlay [j], goalOverlay [j].transform.position, goalOverlay [j].transform.rotation);
			i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);

			isCreated = true;
			/**reset the other counters**/
			Counter.vAmount = rstint;
			Counter.instance.veggie.text = rst;



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
