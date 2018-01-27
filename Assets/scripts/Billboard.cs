using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour {

    public RectTransform RT;

	// Update is called once per frame
	void Update () {
		transform.LookAt(Camera.main.transform);
	}
}
