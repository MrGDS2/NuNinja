using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;

	public static int g=0;
	int count=0;
	public static Food instance;

    //public Dictionary<string, int> d;
    //int[] foods;
  public  List<string> fruit;
    Rigidbody2D rig;


	void Start ()
	{

		instance = this;

		rig = GetComponent<Rigidbody2D>();
		rig.AddForce (transform.up * startForce, ForceMode2D.Impulse);
        //  d= new Dictionary<string, int>() { { "grain", 0 }, { "protein", 0} };
       


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
           
            fruit.Add(slicedFruit.tag);
            Countfruit(fruit);
			Destroy(slicedFruit, 1f);

			Destroy(gameObject);
			show ();


		}




	



	}
    public Dictionary<string, int> Countfruit(IList<string> stuffList)
    {
        Dictionary<string, int> Count = new Dictionary<string, int>();

        foreach (string stuff in stuffList)
        {
            //initialize or increment the count for this item
            if (Count.ContainsKey(stuff))
            {
                Count[stuff]++;
            }
            else
            {
               Count.Add(stuff, 1);
            }
        }


    

        return Count;
    }

    public void show()
	{
     /**   ICollection key = Count.Keys; //get collection of keys

        foreach (string k in key)
        {
            ///
            Debug.Log(k + ":" + Count[k]);

        }
    **/
    }

	public int Counting()
	{
		

		count = g++;
		return count;

	
	}









}