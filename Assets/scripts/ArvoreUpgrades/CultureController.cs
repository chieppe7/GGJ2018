using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultureController : MonoBehaviour {


	public GameManager manager;
	GameObject meme;

	public int levelPlus;
	public int levelMinus;

	public bool plus;

	// Use this for initialization
	void Awake () {

		meme = manager.meme;
	}

	// Update is called once per frame
	public void Initialize () {

		if (plus)
			meme.GetComponent<MemeAtributtes> ().culture += levelPlus;
		else
			meme.GetComponent<MemeAtributtes> ().culture += levelMinus;
	}
}
