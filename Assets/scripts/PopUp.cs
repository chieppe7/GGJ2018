using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour {

    private int Natual = 0;
    private int Fatual = 0;
    private int Ratual = 0;
    private int Matual = 0;

    private int Nnext = 50;
    private int Fnext = 50;
    private int Rnext = 50;
    private int Mnext = 250;

    public CountryAtributtes[] Country;
    public MemeAtributtes MA;
    public GameObject NPopUp;
    public GameObject FPopUp;
    public GameObject RPopUp;
    public GameObject MPopUp;

    private int MemeAtk;


	// Use this for initialization
	void Start () {
        MemeAtk = MA.atk;
        StartCoroutine(Countdown());
	}

    IEnumerator Countdown() {
        Natual += MemeAtk;
        Fatual += MemeAtk;
        Ratual += MemeAtk;
        Matual += MemeAtk;
        yield return new WaitForSeconds(1f);
        StartCoroutine(Countdown());
    }
	
	// Update is called once per frame
	void Update () {
        if (MemeAtk != MA.atk)
            MemeAtk = MA.atk;
        if (Natual >= Nnext) {
            Nnext += 50;
            Natual = 0;
            InstatiatePopUp(0);
        }
        if (Fatual >= Fnext) {
            Fnext += 50;
            Fatual = 0;
            InstatiatePopUp(1);
        }
        if (Ratual >= Rnext) {
            Rnext += 50;
            Ratual = 0;
            InstatiatePopUp(2);
        }
        if (Matual >= Mnext) {
            Mnext += 100;
            Matual = 0;
            InstatiatePopUp(3);
        }
    }

    public void Nup(int UP) {
        Natual += UP;
        Matual += 2 * UP;
    }
    public void Fup(int UP) {
        Fatual += UP;
        Matual += 2 * UP;
    }
    public void Rup(int UP) {
        Ratual += UP;
        Matual += 2 * UP;
    }

    void InstatiatePopUp(int i) {
        int E;
        int b=0;
        do {
            b++;
            if (b > 50) {
                Natual = 0;
                Fatual = 0;
                Ratual = 0;
                Matual = 0;
                return;
            }
            E = Random.Range(0, Country.Length);
        } while (!Country[E].infec || Country[E].HasPopUp);
        if (i == 0) {
            GameObject Clone = Instantiate(NPopUp, Country[E].transform.position, Country[E].transform.rotation);
            Clone.transform.SetParent(Country[E].transform);
            Clone.transform.position = new Vector3(Clone.transform.parent.position.x,2f, Clone.transform.parent.position.z);
            Country[E].HasPopUp = true;
            return;
        }
        if (i == 1) {
            GameObject Clone = Instantiate(FPopUp, Country[E].transform.position,  Country[E].transform.rotation);
            Clone.transform.SetParent(Country[E].transform);
            Clone.transform.position = new Vector3(Clone.transform.parent.position.x,2f, Clone.transform.parent.position.z);
            Country[E].HasPopUp = true;
            return;
        }
        if (i == 2) {
            GameObject Clone = Instantiate(RPopUp, Country[E].transform.position,  Country[E].transform.rotation);
            Clone.transform.SetParent(Country[E].transform);
            Clone.transform.position = new Vector3(Clone.transform.parent.position.x,2f, Clone.transform.parent.position.z);
            Country[E].HasPopUp = true;
            return;
        }
        if (i == 3) {
            GameObject Clone = Instantiate(MPopUp, Country[E].transform.position,  Country[E].transform.rotation);
            Clone.transform.SetParent(Country[E].transform);
            Clone.transform.position = new Vector3(Clone.transform.parent.position.x,2f, Clone.transform.parent.position.z);
            Country[E].HasPopUp = true;
            return;
        }
    }

    public void Rede() {
        Rnext /= 2;
        Fnext /= 2;
        Nnext /= 2;
        Mnext /= 2;
    }

    public void Nnup() {
        Nnext /= 2;
        Mnext /= 2;
    }

    public void Fnup() {
        Fnext /= 2;
        Mnext /= 2;
    }

    public void Rnup() {
        Rnext /= 2;
        Mnext /= 2;
    }

    public void NnupPlus() {
        Nnext /= 2;
        Mnext /= 4;
    }

    public void FnupPlus() {
        Fnext /= 2;
        Mnext /= 4;
    }

    public void RnupPlus() {
        Rnext /= 2;
        Mnext /= 4;
    }

}
