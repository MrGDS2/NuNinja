using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;

	public static int g=0,f=0,v=0,d=0,p=0,o=0;
	public static Food instance;

	//int[] foods;
	Rigidbody2D rig;


	void Start ()
	{
		rig = GetComponent<Rigidbody2D>();
		rig.AddForce (transform.up * startForce, ForceMode2D.Impulse);
		//one.text = g.ToString ();
//		foods =new int[foods.Length];

		//FillArray ();// place zero in every spot


		instance = this;

	}
	void Update()
	{
		//one.text = g.ToString ();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		


		if (col.tag == "swipe")
		{
			Debug.Log ("food hit");
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 1f);
			Destroy(gameObject);


			switch (fruitSlicedPrefab.tag) 
			{
			case "grain":
				//add to grain
				g++;
				//Debug.Log("counting" + "==>" + g);
			//strt=	foods[0]++;
			
				break;
			case "veggie":
				//add to veggie
				v++;
				//strt=	foods[1]++;
				break;
			case "protein":
				//add to protein
				p++;
				//strt=foods[2]++;
				break;



			case "dairy":
				//add to dairy
				d++;
				//strt=foods[3]++;
				break;
			case "fruit":
				//add to fruits
				f++;
			//	strt=foods[4]++;
				break;
			case "oils":
				//add to oils
				o++;
			//	strt=foods[5]++;
			break;



			}



		}
	}

	/**void FillArray()
	{
		for (int i = 0; i < foods.Length; i++)
		{
			foods [i] = strt;
		}
	}
**/

	public int Counting()
	{
		


		//add to grain
			return g;




		//	return strt ;


	}









}