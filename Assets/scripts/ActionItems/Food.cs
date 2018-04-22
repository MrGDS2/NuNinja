using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Food : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;
    Counter cntr = new Counter();
	public static int g=0;
    public static int count3 = 0;
    public int count = 0;

	public static Food instance;
	public int[] fruit;
    //public Dictionary<string, int> d;
    //int[] foods;
    Rigidbody2D rig;
	int bonus=1000;

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

			

			switch (slicedFruit.tag) 
			{

			case  "grain":
                    Counter.type = "grain";
				Counter.amount += bonus;
                    Counter.gAmount += 1;
                   
				break;

			case  "protein":
                    Counter.type = "protein";
                    Counter.amount += bonus;
                    Counter.pAmount += 1;
			
                    break;
            case "dairy":
                Counter.type = "dairy";
                Counter.amount += bonus;
                    Counter.dAmount += 1;
             
                    break;
            case "fruit":
                Counter.type = "fruit";
				Counter.amount += bonus;
                    Counter.fAmount += 1;
           
                    break;
            case "oils":
                Counter.type = "oils";
                Counter.amount -= bonus;
                    Counter.oAmount += 1;
           

				break;
                case "veggie":
                    Counter.type = "veggie";
                Counter.amount += bonus;
                Counter.vAmount += 1;
              
                break;




			}
      
			Destroy(slicedFruit, 1f);

			Destroy(gameObject);



		}




	



	}


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