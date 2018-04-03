using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;

	public static int g=0;
	public int count=0;
	public static Food instance;
	public int[] fruit;
    //public Dictionary<string, int> d;
    //int[] foods;

    Rigidbody2D rig;


	void Start ()
	{

		instance = this;

		rig = GetComponent<Rigidbody2D>();
		rig.AddForce (transform.up * startForce, ForceMode2D.Impulse);
        //  d= new Dictionary<string, int>() { { "grain", 0 }, { "protein", 0} };
       
		fruit = new int[6];



		for(int i=0;i<fruit.Length;i++)
		{

			fruit [i] = count;

		}



//

	}
	void Update()
	{
     // Debug.Log(  Countfruit(fruit));
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


			switch (slicedFruit.tag) 
			{

			case  "grain":
				
				fruit [0] =Counting();

				break;

			case  "protein":
				
				fruit [1] =Counting();

				break;






			}
           // fruit.Add(slicedFruit.tag);
          //  Countfruit(fruit);
			Destroy(slicedFruit, 1f);

			Destroy(gameObject);



		}




	



	}
//    public Dictionary<string, int> Countfruit(IList<string> stuffList)
//    {
//        Dictionary<string, int> Count = new Dictionary<string, int>();
//
//        foreach (string stuff in stuffList)
//        {
//            //initialize or increment the count for this item
//            if (Count.ContainsKey(stuff))
//            {
//                Count[stuff]++;
//            }
//            else
//            {
//               Count.Add(stuff, 1);
//            }
//        }
//
//
//    
//
//        return Count;
//    }

    public void show()
	{
		foreach(int f in fruit)
		{

			print (f);
		}
    }

	public int Counting()
	{
		

		count = g++;
		return count;

	
	}









}