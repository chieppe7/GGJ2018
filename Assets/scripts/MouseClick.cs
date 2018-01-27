using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    RaycastHit Rayhit;

    private CountryAtributtes CountryClick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        if (Input.GetButtonDown("Fire1")) {
            if (Physics.Raycast(ray, out Rayhit, 100)) {
                CountryClick = Rayhit.collider.gameObject.GetComponent<CountryAtributtes>();
                if (CountryClick.HasPopUp) {
                    CountryClick.transform.GetChild(0).GetComponent<PopClick>().Detonate();
                }
            }
        }
	}
}
