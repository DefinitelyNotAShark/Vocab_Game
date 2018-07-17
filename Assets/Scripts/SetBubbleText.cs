using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBubbleText : MonoBehaviour
{ 
    private TextMesh mesh;
    private List<string> VocabWords;

    public int vocabIndex;
    private string selectedVocabWord;

    // Use this for initialization
    void Awake ()
    {
        mesh = GetComponentInChildren<TextMesh>();

        VocabWords = GetTextInput.vocabWords;
        vocabIndex = Random.Range(0, VocabWords.Count);//WILL THIS WORK????

        selectedVocabWord = VocabWords[vocabIndex];
        mesh.text = selectedVocabWord;
	}
}
