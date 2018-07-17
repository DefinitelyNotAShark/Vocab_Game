using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTextInput : MonoBehaviour
{
    private GameObject[] vocabObjects;
    private GameObject[] meaningObjects;

    [SerializeField]
    private InputField[] vocabs;

    [SerializeField]
    private InputField[] meanings;

    public static List<string> vocabWords;
    public static List<string> meaningWords;

    private void Start()
    {
        vocabWords = new List<string>();
        meaningWords = new List<string>();

        //make a list of objects that are input fields for vocab
        vocabObjects = GameObject.FindGameObjectsWithTag("VocabField");

        //make a list of objects that are input for meaning
        meaningObjects = GameObject.FindGameObjectsWithTag("MeaningField");
    }

    public void SetText()//called when confirm button is pushed?
    {
        vocabWords.Clear();
        meaningWords.Clear();

            for (int i = 0; i < vocabs.Length; i++)//cycle through each input field and add text to list
            {
                if (vocabs[i].text != "")
                    vocabWords.Add(vocabs[i].text);
            }

            for(int i = 0; i < vocabs.Length; i++)
            {
                if(meanings[i].text != "")
                meaningWords.Add(meanings[i].text);
            }
    }

    public bool InputIsEnough()
    {
        //This function catches when someone doesn't type enough words (wordcap is 4 each) or if they don't define something
        if (vocabWords.Count != meaningWords.Count || vocabWords.Count + meaningWords.Count < 8)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
