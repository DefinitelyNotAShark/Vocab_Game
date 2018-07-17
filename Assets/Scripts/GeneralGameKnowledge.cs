using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameKnowledge : MonoBehaviour
{
    public static bool gameOver = false;
    public static List<string> meaningSlots;
    public static bool BubbleSelected = false;
    public static bool MeaningSelected = false;

    public static string VocabWordSelected;
    public static string MeaningWordSelected;

    private void Awake()
    {
        meaningSlots = new List<string>();
    }
}
