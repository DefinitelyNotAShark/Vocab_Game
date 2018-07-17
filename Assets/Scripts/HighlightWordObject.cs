using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightWordObject : MonoBehaviour
{
    private TextMesh mesh;

    public CheckMatch checkMatch;
    public bool selected = false;

    // Use this for initialization
    void Awake()
    {
        mesh = GetComponentInChildren<TextMesh>();
        checkMatch = GetComponent<CheckMatch>();
    }

    private void OnMouseEnter()
    {
        if (!selected)
            mesh.color = Color.gray;
    }

    private void OnMouseExit()//turn outline off when mouse leaves
    {
        if (selected)
            mesh.color = Color.white;

        else
            mesh.color = Color.black;
    }

    private void OnMouseDown()//only works for bubbles so farrr...
    {
        if (this.gameObject.tag == "Bubble")
            ManageBubbleSelection();

        else if (this.gameObject.tag == "MeaningObject")
            ManageMeaningSelection();
          
    }


    private void ManageBubbleSelection()
    {
        if (mesh.color == Color.white)//if we're clicking on it, and it's already selected, we unselect
        {
            mesh.color = Color.black;
            GeneralGameKnowledge.BubbleSelected = false;//this tells the game manager that it's unselected.
            selected = false;
        }

        else if (GeneralGameKnowledge.BubbleSelected == true)//if we're clicking on it, and another bubble is selected...
        {
            Debug.Log("I already have a different bubble selected!");
        }

        else if (GeneralGameKnowledge.BubbleSelected == false)
        {
            mesh.color = Color.white;
            GeneralGameKnowledge.BubbleSelected = true;//this tells the game manager that it is selected!

            //this line sets the int to the index of the word that is attatched to the object
            CheckMatch.vocabInt = GetTextInput.vocabWords.IndexOf(mesh.text);
            GeneralGameKnowledge.CurrentBubbleSelected = this.gameObject;
            selected = true;
        }
    }

    private void ManageMeaningSelection()
    {
        if (mesh.color == Color.white)//if we're clicking on it, and it's already selected, we unselect
        {
            mesh.color = Color.black;
            GeneralGameKnowledge.MeaningSelected = false;//this tells the game manager that it's unselected.
            selected = false;
        }

        else if (GeneralGameKnowledge.MeaningSelected == true)//if we're clicking on it, and another bubble is selected...
        {
            Debug.Log("I already have a different meaning selected!");
        }

        else if (GeneralGameKnowledge.MeaningSelected == false)
        {
            mesh.color = Color.white;
            GeneralGameKnowledge.MeaningSelected = true;//this tells the game manager that it is selected!

            //this line sets the int to the index of the word that is attatched to the object
            CheckMatch.meaningInt = GetTextInput.meaningWords.IndexOf(mesh.text);
            selected = true;
        }
    }
}

