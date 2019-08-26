using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    public UnityEngine.UI.Text Display;

    public float stardust = 0.00f;
    public int starPerClick = 1;
    public int starPerSeg = 0;

   void Update()
    {
        Display.text = " stardust " + stardust + " perClick: " + starPerClick + " perSeg: " + starPerSeg;
    }

    public void Clicked()
    {
        stardust += starPerClick;
    }

}