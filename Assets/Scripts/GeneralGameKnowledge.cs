using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameKnowledge : MonoBehaviour
{
    public static bool gameOver = false;//whether the game over needs to happen

    public static List<string> meaningSlots;//how many slots need to be filled with non-repeating words

    public static bool BubbleSelected = false;//whether a bubble is selected
    public static bool MeaningSelected = false;//whether a word from the bank is selected

    public static string VocabWordSelected;//the actual string of the bubble word
    public static string MeaningWordSelected;//the actual string of the vocab word

    public static GameObject CurrentBubbleSelected;

    private void Awake()
    {
        meaningSlots = new List<string>();
    }
}
