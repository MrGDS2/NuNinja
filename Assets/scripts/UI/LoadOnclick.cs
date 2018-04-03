using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadOnclick : MonoBehaviour {

	public LoadOnclick instance;

	void start()
	{
		instance = this;
	}


	public void Loadscene(string level)
	{

		SceneManager.LoadScene (level);
	}
}
