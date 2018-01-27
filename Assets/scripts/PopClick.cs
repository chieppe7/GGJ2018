using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopClick : MonoBehaviour {

    public int PopType;
    private PopUp PU;

    private CountryAtributtes CA;

    private void Start() {
        PU = GameObject.FindGameObjectWithTag("PopUpManager").GetComponent<PopUp>();
        CA = transform.parent.gameObject.GetComponent<CountryAtributtes>();
        StartCoroutine(selfDestruct());
    }

    IEnumerator selfDestruct() {
        yield return new WaitForSeconds(10f);
        die();
    }

    void die() {
        if (PopType == 0 && CA.prov == ("9gag")) {
            //perde pontos
        }
        if (PopType == 1 && CA.prov == ("4chan")) {
            //perde pontos
        }
        if (PopType == 2 && CA.prov == ("reddit")) {
            //perde pontos
        }
        CA.HasPopUp = false;
        Destroy(this.gameObject);
    }

    public void Detonate() {
        if (PopType == 0) {
            PU.Nup(10);
            //if major bonus coins else more cure
        }
        if (PopType == 1) {
            PU.Fup(10);
            //if major bonus coins else more cure
        }
        if (PopType == 2) {
            PU.Rup(10);
            //if major bonus coins else more cure
        }
        if (PopType == 3) {
            //abre janela meme
        }
        CA.HasPopUp = false;
        Destroy(this.gameObject);
    }
}
