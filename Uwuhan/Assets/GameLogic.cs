using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static int numPills = 0;
    public static bool gotCure = false;

    public static bool IsWin()
    {
        if (numPills == 6 && gotCure)
        {
            print("You have won the game!");
            return true;
        }

        return false;
    }

    public static void ShowWin()
    {
        print("You won!");
    }

    public static void IncrementPills() 
    {
        numPills++;
        TextChangerScript.UpdateText();
    }

    public static void ToggleCure()
    {
        gotCure = true;
        TextChangerScript.UpdateText();
    }

}
