using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopClick : MonoBehaviour {

    public int PopType;
    private GameManager GM;
    private PopUp PU;
    private MemeCurrency MC;
    private MemePopUp MP;

    private CountryAtributtes CA;

    private void Start() {
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        MP = GameObject.FindGameObjectWithTag("Canvas").GetComponent<MemePopUp>();
        MC = GameObject.FindGameObjectWithTag("Player").GetComponent<MemeCurrency>();
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
            MC.Currency -= 20;
        }
        if (PopType == 1 && CA.prov == ("4chan")) {
            MC.Currency -= 20;
        }
        if (PopType == 2 && CA.prov == ("reddit")) {
            MC.Currency -= 20;
        }
        CA.HasPopUp = false;
        Destroy(this.gameObject);
    }

    public void Detonate() {
        if (PopType == 0) {
            PU.Nup(10);
            if (CA.prov == "9gag")
                MC.Currency += 10;
            else
                GM.notoriety += 1;
        }
        if (PopType == 1) {
            PU.Fup(10);
            if(CA.prov=="4chan")
                MC.Currency += 10;
            else
                GM.notoriety += 1;
        }
        if (PopType == 2) {
            PU.Rup(10);
            if(CA.prov=="reddit")
                MC.Currency += 10;
            else
                GM.notoriety += 1;
        }
        if (PopType == 3) {
            MP.MemeActive();
        }
        CA.HasPopUp = false;
        Destroy(this.gameObject);
    }
}
