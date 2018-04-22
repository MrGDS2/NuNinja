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
	Color goal=new Color32(0x33,0xFF,0x00,0xFF);


	bool isCreated=false;



	void Start () {
	//	trackitem.Add (Counter.instance.fScore);


	
	}
	
	// Update is called once per frame
	void Update () {

	
		Debug.Log("game" + trackitem[0].text);
		if ( trackitem[0].text.Contains("1") && !isCreated) 
		{   
			trackitem [0].color = goal;
			Time.timeScale = 0; //pause game for overlay screen
			i=Instantiate(goalOverlay[0],goalOverlay[0].transform.position,goalOverlay[0].transform.rotation);
			i.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);

			isCreated = true;
		}

			
	}



	public void onConfirm()
	{


		press++; //counts pressed 'ok' button

		/*limit set to how many times usr can press ok 
		 * & view next slide==> until end**/
		goalOverlay.Remove(goalOverlay [0]);
		Destroyoverlay (goalOverlay [0]);

	}

	void Destroyoverlay(GameObject Overlay)
	{
		if (press == limitpress)
		{
			Destroy (Overlay);
			Time.timeScale = 1;
		}
	}

	Color Colorset(Color col)
	{

		return 	Counter.instance.fScore.color = col;

			}

}
