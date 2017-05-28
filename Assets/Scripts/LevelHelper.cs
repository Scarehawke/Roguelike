using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHelper : MonoBehaviour {

	public int currentLevel = 1;
	public int enemySpawnRate = 80;



	void Start () {
		DontDestroyOnLoad (this);


		if (GameObject.FindGameObjectsWithTag ("LevelHelper").Length > 1) {
			Destroy (gameObject);
		}

	}

}
