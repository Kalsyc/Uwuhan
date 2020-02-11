using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static int numPills = 0;

    public bool isWin()
    {
        if (numPills == 5)
        {
            print("You have won the game!");
            return true;
        }

        return false;
    }

    public static void IncrementPills() {
        numPills++;
        TextChangerScript.UpdateText();
    }

}
