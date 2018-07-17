using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMatch : MonoBehaviour
{
    private bool CheckIfMatch()//checks if both a bubble and a word are selected
    {
        if (GeneralGameKnowledge.BubbleSelected == true && GeneralGameKnowledge.MeaningSelected == true)
        {
            return true;
        }
        else
            return false;
    }

    private bool isMatchCorrect()//checks the word indexes...If numbers are equal, return true, else false
    {
        return false;
    }

    private void Update()
    {
        if (CheckIfMatch())
        {
            Debug.Log("You do have 2 selected, congrats");
        }
    }
}
