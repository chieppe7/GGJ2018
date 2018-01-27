using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemePopUp : MonoBehaviour {

    public Image meme;
    public Image close;

	// Use this for initialization
	void Start () {
        meme.enabled = false;
        close.enabled = false;
	}

    public void MemeActive() {
        Debug.Log("Active");
        meme.enabled = true;
        close.enabled = true;
        close.rectTransform.position = new Vector3(Random.Range(-6f,6f),Random.Range(-2.5f,2.5f),close.rectTransform.position.z);
    }

    public void MemeDeactive() {
        Debug.Log("Deactive");
        meme.enabled = false;
        close.enabled = false;
    }
}
