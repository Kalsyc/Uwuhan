using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangerScript : MonoBehaviour
{
    static Text pillText;

    void Start()
    {
        pillText = GetComponent<Text>();
    }

    

    public static void UpdateText() {
        if (GameLogic.gotCure)
        {
            pillText.text = "RUN NOW AND FIND THE PORTAL TO ESCAPE!";
            return;
        }
        pillText.text = "Number of Pills Collected: " + GameLogic.numPills + " / 6 pills";
    }
}
