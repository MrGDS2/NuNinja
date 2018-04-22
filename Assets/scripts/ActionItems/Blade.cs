using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

	public GameObject trailPrefab;

	public float minCutVelcity;

	bool Cutting=false;

	Rigidbody2D rig;

	GameObject currentTrail;

	CircleCollider2D circle;

	Vector2 previousPosition;



	//Vector3 p = new Vector3();


	Vector2 mousePos = new Vector2();
	 Camera mCam;
	void Start()
	{
		mCam = Camera.main;
		rig = GetComponent<Rigidbody2D> ();
		circle = GetComponent<CircleCollider2D> ();
	
	}


	// Update is called once per frame
	void Update () {



		//will change for phone
		if(Input.GetMouseButtonDown(0)) //left click on PC 
		{
			StartCut ();
		}
		else if(Input.GetMouseButtonUp(0))
		EndCut ();    //on release click

		if (Cutting)
		{
			UpdateCut ();
		}
     }
	/*method follows mouse clicks and updates cut animation*/
	void UpdateCut()
	{
		// Get the mouse position from Event.
		Vector3 input = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, mCam.nearClipPlane);
		/*allows for input of mouse to be traced*/
		Vector2 newPosition = mCam.ScreenToViewportPoint(input);
		rig.position = newPosition;

		float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime; //get velocity of cut 

		if (velocity > minCutVelcity) {
			circle.enabled = true;
		} else
			circle.enabled = false;

		previousPosition = newPosition;//updates previous position
	
	}

	void StartCut()
	{
		Cutting = true;
		//makes new cut on each click
		currentTrail=Instantiate (trailPrefab, transform);
		circle.enabled = true;
	}


	void EndCut()
	{
		Cutting = false;
		//currentTrail.transform.SetParent (null);
		Destroy (currentTrail, 2f);
		circle.enabled = false;
	}

}