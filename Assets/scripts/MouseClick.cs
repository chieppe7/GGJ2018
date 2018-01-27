using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    RaycastHit Rayhit;
    private MemePopUp control;

	// Use this for initialization
	void Start () {
        control = GameObject.FindGameObjectWithTag("Canvas").GetComponent<MemePopUp>();
	}
	
	// Update is called once per frame
	void Update () {
        CountryAtributtes CountryClick=null;
        MemePopUp MP=null;
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        if (Input.GetButtonDown("Fire1")) {
            if (Physics.Raycast(ray, out Rayhit, 100)) {
                if(Rayhit.collider.tag=="CanvasButton")
                    MP = Rayhit.collider.gameObject.GetComponent<CanvasReference>().MP;
                else
                    CountryClick = Rayhit.collider.gameObject.GetComponent<CountryAtributtes>();
                if(CountryClick && !control.meme.enabled)
                    if (CountryClick.HasPopUp) {
                        CountryClick.transform.GetChild(0).GetComponent<PopClick>().Detonate();
                    }
                if (MP)
                    MP.MemeDeactive();
            }
        }
	}
}
