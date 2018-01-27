using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemePopUp : MonoBehaviour {

    public Image meme;
    public Button close;

	// Use this for initialization
	void Start () {
        meme.enabled = false;
        close.enabled = false;
	}

    void Update()
    {
        close.image.enabled = close.enabled;

    }

    public void MemeActive() {
        Debug.Log("Active");
        meme.enabled = true;
        close.enabled = true;
        close.transform.localPosition = new Vector3(Random.Range(-344f,344f),Random.Range(-144.5f,144.5f),close.transform.position.z);
    }

    public void MemeDeactive() {
        Debug.Log("Deactive");
        meme.enabled = false;
        close.enabled = false;
    }
}
