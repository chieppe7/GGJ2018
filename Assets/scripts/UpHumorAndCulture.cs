using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHumorAndCulture : MonoBehaviour {

    public int culture;
     public  int humor;

    public int defPlus;
    public GameManager manager;

	// Use this for initialization
	void Awake () {


		
	}
	
	// Update is called once per frame
	void Update () {

        culture = GetComponent<CountryAtributtes>().cultureCC;
        humor = GetComponent<CountryAtributtes>().humor;

        ChanceThings();


    }

    void ChanceThings()
    {

        if (culture > 0 || culture == 0)
        {

            defPlus = culture - manager.meme.GetComponent<MemeAtributtes>().culture;
        }
        else
            defPlus = (-1 * culture) + manager.meme.GetComponent<MemeAtributtes>().culture;

        if (humor > 0 || humor == 0)
        {

            defPlus = humor - manager.meme.GetComponent<MemeAtributtes>().humor;
        }
        else
            defPlus = (-1 * humor) + manager.meme.GetComponent<MemeAtributtes>().humor;


    }
}
