using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumorCultura : MonoBehaviour {

    private int Cp = 1;
    private int Cm = 1;
    private int Hp = 1;
    private int Hm = 1;

    public MemeAtributtes meme;

    public void Cup()
    {
        meme.culture += Cp;
        if (Cp < 8)
            Cp *= 2;
    }
    public void Cdown()
    {
        meme.culture -= Cm;
        if (Cm < 8)
            Cm *= 2;
    }
    public void Hup()
    {
        meme.humor += Hp;
        if (Hp < 8)
            Hp *= 2;
    }
    public void Hdown()
    {
        meme.humor -= Hm;
        if (Hm < 8)
            Hm *= 2;
    }
}
