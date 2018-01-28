using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemeCurrency : MonoBehaviour {

    public int Currency;
    public Text dim;

    private void Start()
    {
        StartCoroutine(MoneyOverTime());
    }

    IEnumerator MoneyOverTime()
    {
        yield return new WaitForSeconds(3f);
        Currency++;
        StartCoroutine(MoneyOverTime());
    }

    // Update is called once per frame
    void Update () {
        if (Currency < 0)
            Currency = 0;

        dim.text = Currency.ToString();

    }


}