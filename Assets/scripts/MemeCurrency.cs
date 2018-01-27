using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeCurrency : MonoBehaviour {

    public int Currency;
	
	// Update is called once per frame
	void Update () {
        if (Currency < 0)
            Currency = 0;
	}
}