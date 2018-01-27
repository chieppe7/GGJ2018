using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameManager manager;
    public Text LBLnotoriety;
    public int notoriety;

    public int level;
    public float cont;

    public bool go;
    public bool notable;

	// Use this for initialization
	void Update () {

        cont = manager.notoriety + manager.meme.GetComponent<MemeAtributtes>().atk;

        if (go) {
            UpdateLevel();
            go = false;
        }

        if (manager.meme.GetComponent<MemeAtributtes>().atk > 45 && !notable)
        {
            manager.notoriety += 50;
            notable = true;
        }

        LBLnotoriety.text = notoriety.ToString();
		
	}
	
	// Update is called once per frame
	void UpdateLevel () {

        if (cont < 20) {
            level = 0;
            StartCoroutine("wait");
        }
        if (cont > 20 && cont < 41)
        {
            level = 1;
            StartCoroutine("wait1");
        }
        if (cont > 40 && cont < 61)
        {
             level = 2;
            StartCoroutine("wait2");
        }
        if (cont > 60 && cont < 81)
        {
             level = 3;
            StartCoroutine("wait3");
        }
        if (cont > 80 && cont < 101)
        {
            level = 4;
            StartCoroutine("wait4");
        }
        if (cont > 100 && cont < 121)
        {
            level = 5;
            StartCoroutine("wait5");
        }
        if (cont > 120 && cont < 141)
        {
            level = 6;
            StartCoroutine("wait6");
        }
        if (cont > 140)
        { 
            level = 7;
            StartCoroutine("wait7");
        }

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(50f);
        if (level == 0)
        {
            StartCoroutine("wait");
            notoriety++;
        }

    }

    IEnumerator wait1()
    {

        yield return new WaitForSeconds(20f);
        if (level == 1) {
            StartCoroutine("wait1");
            notoriety++;
        }
            
    }

    IEnumerator wait2()
    {

        yield return new WaitForSeconds(15f);
        if (level == 2)
        {
            StartCoroutine("wait2");
            notoriety++;
        }
    }

    IEnumerator wait3()
    {

        yield return new WaitForSeconds(12f);
        if (level == 3)
        {
            StartCoroutine("wait3");
            notoriety++;
        }
    }

    IEnumerator wait4()
    {

        yield return new WaitForSeconds(10f);
        if (level == 4) {
            StartCoroutine("wait4");
            notoriety++;
        }
    }

    IEnumerator wai5t()
    {

        yield return new WaitForSeconds(7f);
        if (level == 5)
        {
            StartCoroutine("wait5");
            notoriety++;
        }
    }

    IEnumerator wait6()
    {

        yield return new WaitForSeconds(4f);
        if (level == 6)
        {
            StartCoroutine("wait6");
            notoriety++;
        }
    }

    IEnumerator wait7()
    {

        yield return new WaitForSeconds(2f);
        if (level == 7)
        {
            StartCoroutine("wait7");
            notoriety++;
        }
    }
}
