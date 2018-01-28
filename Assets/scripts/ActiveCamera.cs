using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour {

    public GameObject cam;
    public GameObject agua;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

   public void Go (){

        cam.active = true;
        agua.active = false;
        StartCoroutine("gi");
}

    IEnumerator gi()
    {
        yield return new WaitForSeconds(10f);
        agua.active = true;
    }
}
