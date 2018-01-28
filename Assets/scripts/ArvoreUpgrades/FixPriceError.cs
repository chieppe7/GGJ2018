using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixPriceError : MonoBehaviour {

    public Button dad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       gameObject.GetComponent<Text>().enabled = dad.GetComponent<Image>().enabled;
		
	}
}
