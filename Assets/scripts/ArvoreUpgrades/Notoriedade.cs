using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Notoriedade : MonoBehaviour {

	public GameManager manager;
	GameObject meme;

	public int atk;
	public int notoriety;

    public bool isOn;
    public Button[] depend;

	// Use this for initialization
	void Awake () {

		meme = manager.meme;
	}
	
	// Update is called once per frame
	public void Initialize () {

		meme.GetComponent<MemeAtributtes> ().atk += atk;
		manager.notoriety += notoriety;
        manager.GetComponent<EnemyController>().go = true;

        GetComponent<AudioSource>().Play();
        isOn = true;
        GetComponent<Image>().enabled = false;
    }

    void Update()
    {
        int j =0;
        for (int i = 0; i < depend.Length; i++) {

            

            if (depend[i].GetComponent<Notoriedade>().isOn)
            {
                j++;
            }

            if (j == depend.Length && !isOn)
                GetComponent<Image>().enabled = true;
            else
                GetComponent<Image>().enabled = false;
        }

    }
}
