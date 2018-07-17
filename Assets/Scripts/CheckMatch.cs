using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMatch : MonoBehaviour
{
    public static int vocabInt;
    public static int meaningInt;

    private ParticleSystem[] particles;

    private bool bubbleIsPopping = false;
    private PopBubble pop;

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
        if (vocabInt == meaningInt)
            return true;

        else
            return false;
    }

    private void Update()
    {
        if (CheckIfMatch())
        {
            if(isMatchCorrect())//this checks to see if you got the right match
            {
                Debug.Log("The match is correct!!!");//oh my god it works on the first try im gonna die!!!

                if(!bubbleIsPopping)
                StartCoroutine(Pop());
            }
        }
    }

    IEnumerator Pop()
    {
        bubbleIsPopping = true;
        //play pop sound!
        particles = GeneralGameKnowledge.CurrentBubbleSelected.GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem p in particles)
        {
            p.Play();
        }
        GeneralGameKnowledge.CurrentBubbleSelected.GetComponent<Renderer>().enabled = false;//also need to make number invisible
        GeneralGameKnowledge.CurrentBubbleSelected.GetComponentInChildren<TextMesh>().text = "";
        yield return new WaitForSeconds(1);
        foreach (ParticleSystem p in particles)
        {
            p.Stop();
        }
        GeneralGameKnowledge.BubbleSelected = false;
        Destroy(GeneralGameKnowledge.CurrentBubbleSelected);
        bubbleIsPopping = false;
    }

    private void SpawnNewBankWord()
    {
        //change words in bank (unless 4 words)
    }
}
