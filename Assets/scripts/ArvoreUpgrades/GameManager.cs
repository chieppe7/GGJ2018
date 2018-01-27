using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public GameObject meme;

	public int notoriety;
	public float timeNototiety;

	// Use this for initialization
	void Awake () {

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator wait(){

		yield return WaitForSeconds (timeNototiety);

			StartCoroutine("wait");
	}
}
