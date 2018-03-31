using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;

	public static int g=0;
	int count=0;
	public static Food instance;

	public 	Hashtable f;
	//int[] foods;
	Rigidbody2D rig;


	void Start ()
	{

		instance = this;

		rig = GetComponent<Rigidbody2D>();
		rig.AddForce (transform.up * startForce, ForceMode2D.Impulse);
		f = new Hashtable ();
		has
//

	}
	void Update()
	{

	}


	void OnTriggerEnter2D (Collider2D col)
	{
		/*on each swipe*/
		if (col.tag == "swipe")
		{
		//Debug.Log ("food hit");
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);

			Debug.Log (slicedFruit.tag + " hit");

			f.Add (slicedFruit.tag, count);
			count = g++;
//			f [slicedFruit.tag] = count;


//			switch(slicedFruit.tag)
//			{
//			case "grain":
//				f ["grain"] = Counting ();
//				break;
//
////			case "veggie":
////				f ["veggie"] = Counting ();
////				break;
//			}
			Destroy(slicedFruit, 1f);

			Destroy(gameObject);
			show ();


		}




	



	}


	public void show()
	{

		ICollection key = f.Keys; //get collection of keys

		foreach (string k in key)
		{
			///
			Debug.Log(k + ":" + f[k]);

		}

	}

	public int Counting()
	{
		

		count = g++;
		return count;

	
	}









}