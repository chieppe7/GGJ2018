using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryAtributtes : MonoBehaviour {

    public int defAtual;
    public int def;
	public int num;
	public int[] tong;
	public int[] border;
	public bool infec;
	public string type;
	public int cultureCC;
	public int humor;
	public string prov;
	public float percentInfec;
    public bool HasPopUp = false; //se ja tiver, nao pode ter dois
    public bool memeIsHere;
    public int defPlus;
 

    int rnd;
    bool stop;

    public GameManager manager;

	// Use this for initialization
	void Awake () {

        rnd = Random.Range(1, 4);

        if (rnd == 1)
            type = "reddit";
        else if (rnd == 2)
            type = "4chan";
        else
            type = "9gag";

        humor = Random.Range(-19, 19);
        def = Random.Range(25, 80);

        ChanceThings();

    }
	
	// Update is called once per frame
	void Update () {

        defAtual = def + defPlus;

        if (percentInfec > 50) {
            infec = true;
        }

        if (manager.meme.GetComponent<MemeAtributtes>().atk > defAtual) {
            memeIsHere = true;
        }

        if (memeIsHere && !stop)
        {
            percentInfec++;
            StartCoroutine("wait");
            stop = true;
        }

        if (percentInfec > 99)
            percentInfec = 100;

            ChanceThings();
      

    }

    IEnumerator wait()
    {

        yield return new WaitForSeconds(2f);
        percentInfec += manager.meme.GetComponent<MemeAtributtes>().atk / 40;
        StartCoroutine("wait");
    }

    void ChanceThings()
    {

        if (cultureCC > 0 || cultureCC == 0)
        {

            defPlus = cultureCC - manager.meme.GetComponent<MemeAtributtes>().culture;
        }
        else
            defPlus = (-1 * cultureCC) + manager.meme.GetComponent<MemeAtributtes>().culture;

        if (humor > 0 || humor == 0)
        {

            defPlus = humor - manager.meme.GetComponent<MemeAtributtes>().humor;
        }
        else
            defPlus = (-1 * humor) + manager.meme.GetComponent<MemeAtributtes>().humor;
    }
}
