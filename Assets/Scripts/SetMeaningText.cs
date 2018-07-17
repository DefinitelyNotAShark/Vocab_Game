using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMeaningText : MonoBehaviour
{ 

    private TextMesh mesh;
    private List<string> meaningWords;

    public int meaningIndex;
    private string selectedMeaningWord;

    // Use this for initialization
    void Awake()
    {
        mesh = GetComponentInChildren<TextMesh>();//get the component that can change the text           
    }

    private void Start()
    {
        ChooseWord();
    }

    void ChooseWord()
    {
        meaningWords = GetTextInput.meaningWords;
        meaningIndex = Random.Range(0, meaningWords.Count);//get a random number 
        selectedMeaningWord = meaningWords[meaningIndex];//set it to a random word
        SetWordToText();
    }

    void SetWordToText()
    {
        if (GeneralGameKnowledge.meaningSlots.Contains(selectedMeaningWord))//if we already have that word, we choose a new one!
        {
            //Debug.Log("There are repeats!"); only needed for debugging
            ChooseWord();
        }
        else
        {
            GeneralGameKnowledge.meaningSlots.Add(selectedMeaningWord);//add that word to the list so we know which words are on screenS
        }
        
        mesh.text = selectedMeaningWord;//change the text to be that word
    }
}
