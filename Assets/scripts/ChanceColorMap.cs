using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceColorMap : MonoBehaviour
{

    public GameObject[] countrys;
    public Material[] colors;
    public float unity;
    public float infecLevel;

    // Use this for initialization
    void Start()
    {
        if (countrys.Length > colors.Length)
        {
            unity = countrys.Length / colors.Length;
            //print(gameObject.name+ "uhbnjk");
        }
        else
        {
            unity = 1;
            //print(gameObject.name);
        }

    }

    // Update is called once per frame
    void Update()
    {

        float infecContrys = 0;

        for (int i = 0; i < countrys.Length; i++)
        {

            if (countrys[i].GetComponent<CountryAtributtes>().infec)
            {
                infecContrys++;
            }
        }

        infecLevel = infecContrys / unity;

        if((int)infecLevel < 4)
            gameObject.GetComponent<Renderer>().material = colors[(int)infecLevel];
        else
            gameObject.GetComponent<Renderer>().material = colors[4];



    }
}

