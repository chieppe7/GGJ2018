using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryAtributtes : MonoBehaviour {

	public int def;
	public int num;
	public int[] tong;
	public int[] border;
	public bool infec;
	public string type;
	public int culture;
	public int humor;
	public string prov;
	public float percentInfec;
    public bool HasPopUp = false; //se ja tiver, nao pode ter dois
    public bool memeIsHere;

    int rnd;
    bool stop;

    public GameManager manager;

	// Use this for initialization
	void Start () {

        rnd = Random.Range(1, 4);

        if (rnd == 1)
            type = "reddit";
        else if (rnd == 2)
            type = "4chan";
        else
            type = "9gag";

    }
	
	// Update is called once per frame
	void Update () {

        if (percentInfec > 50) {
            infec = true;
        }

        if (manager.meme.GetComponent<MemeAtributtes>().atk > def) {
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
		
	}

    IEnumerator wait()
    {

        // yield return new WaitForSeconds(100f - manager.meme.GetComponent<MemeAtributtes>().atk);
        // percentInfec++;
        // StartCoroutine("wait");

        yield return new WaitForSeconds(2f);
        percentInfec += manager.meme.GetComponent<MemeAtributtes>().atk / 40;
        StartCoroutine("wait");
    }
}
