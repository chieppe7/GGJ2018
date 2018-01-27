﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notoriedade : MonoBehaviour {

	public GameManager manager;
	GameObject meme;

	public int atk;
	public int notoriety;
    public GameObject enemy;

	// Use this for initialization
	void Awake () {

		meme = manager.meme;
	}
	
	// Update is called once per frame
	public void Initialize () {

		meme.GetComponent<MemeAtributtes> ().atk += atk;
		manager.notoriety += notoriety;
        enemy.GetComponent<EnemyController>().go = true;
	}
}
