using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetThemeColorInGame : MonoBehaviour
{
    [SerializeField]
    private Button activateButton;

    [SerializeField]
    private GameObject[] walls;

    private SpriteRenderer renderer;

    private Color alphaRed;

    public static Color myColor;//this is set by another script cause I'm too lazy to do stuff

    private ColorBlock colorBlock;//i don't quite know how this works, but the internet told me that it does

	void Start ()
    {
         alphaRed = new Color(255, 0, 0, 255);

        if (myColor == null)
            myColor = alphaRed;

        //Set the Normal color for the button
        colorBlock = activateButton.colors;
        colorBlock.normalColor = Color.white;
        colorBlock.highlightedColor = Color.white;//doesn't need one. There's a known bug here, and I don't want to deal with it right now.
        colorBlock.pressedColor = myColor;
        activateButton.colors = colorBlock;

        //Set color for the border...
        foreach(GameObject g in walls)
        {
            renderer = g.GetComponent<SpriteRenderer>();
            renderer.color = myColor;
        }
        //Maybe random colors for the bubbles....
	}
}
