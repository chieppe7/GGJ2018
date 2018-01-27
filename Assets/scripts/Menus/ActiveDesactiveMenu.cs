using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDesactiveMenu : MonoBehaviour {

    public GameObject menu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Active () {

        menu.active = !menu.active;

        //gameObject.active = menu.active;


    }
}
