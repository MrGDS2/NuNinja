using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] foodPrefab;
	public Transform[] spawnPoints;

	public float delayMin=.1f;
	public float delayMax = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnFood());

	}
	
	IEnumerator SpawnFood()
	{
		while (true) 
		{
			/*range of spawn rate .1 to 1*/
			float delay = Random.Range (delayMin, delayMax);
			yield return new WaitForSeconds (delay);

			/*range of spawn points*/
			int spawnIndex = Random.Range (0, spawnPoints.Length);

			Transform spawnPoint = spawnPoints [spawnIndex];


			int randFood =Random.Range (0, foodPrefab.Length);

			Instantiate (foodPrefab[randFood], spawnPoint.position, spawnPoint.rotation);
		}

	}
}
