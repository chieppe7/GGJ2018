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

        unity = countrys.Length / colors.Length;
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

        gameObject.GetComponent<Renderer>().material = colors[(int)infecLevel];
            
        }
    }

