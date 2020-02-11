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
        pillText.text = "Number of Pills Collected: " + GameLogic.numPills + " pills";
    }
}
