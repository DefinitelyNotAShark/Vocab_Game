using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Text alertText;

    private Text colorConfirmationText;
    private Button easyButton;
    private Button normalButton;
    private Button hardButton;
    private Color Red = new Color32(255, 118, 118, 255);
    private Color Yellow = new Color32(255, 234, 118, 255);
    private Color Green = new Color32(118, 255, 130, 255);
    private Color Blue = new Color32(118, 255, 232, 255);
    private Color Purple = new Color32(196, 118, 255, 255);
    private Color Pink = new Color32(255, 118, 200, 255);
    private Color DarkBlue = new Color32(118, 142, 255, 255);
    private Color Lime = new Color32(213, 255, 118, 255);
    private Color Orange = new Color32(255, 178, 118, 255);
    private Color Black = new Color32(77, 77, 77, 255);

    private Color myColor;

    public enum Difficulty {easy, normal, hard}
    public Difficulty myDifficulty;

    private GetTextInput input;

    public void onPlayClick()
    {
        SceneManager.LoadScene("PrePlay");
    }

    private void Start()
    {
        alertText = GameObject.Find("AlertText").GetComponent<Text>();
        alertText.text = "";
    }

    public void onInstructionsClick()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void onCreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }

    public void onBackClick()
    {
        SceneManager.LoadScene("Menu");
    }

    public void onStartClick()//after hitting play, after settings are set
    {
        input = GameObject.Find("GetTextInputObject").GetComponent<GetTextInput>();
        input.SetText();//this puts all the words typed in 2 lists of vocab and meaning words

        if (input.InputIsEnough() == true)//only go to next scene if words are typed right!
        {
            Debug.Log("Everything seems to be in order");
            if (myColor == null)//sets default color if u do not choose
            {
                myColor = Red;
                colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
                colorConfirmationText.text = "Red";
                colorConfirmationText.color = myColor;
            }
            if (myDifficulty != Difficulty.easy || myDifficulty != Difficulty.hard)
            {
                myDifficulty = Difficulty.normal;
            }        
            SetThemeColorInGame.myColor = myColor;

            SceneManager.LoadScene("MainScene");
        }
        else
        {
            alertText = GameObject.Find("AlertText").GetComponent<Text>();
            alertText.text = "Please make sure you've typed more than 4 words and that both columns are filled out!";
        }
    }

    #region onColorClicks
    public void onRedClick()
    {
        myColor = Red;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Red";
        colorConfirmationText.color = myColor;
    }

    public void onYellowClick()
    {
        myColor = Yellow;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Yellow";
        colorConfirmationText.color = myColor;
    }
    public void onGreenClick()
    {
        myColor = Green;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Green";
        colorConfirmationText.color = myColor;
    }
    public void onBlueClick()
    {
        myColor = Blue;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Blue";
        colorConfirmationText.color = myColor;
    }
    public void onPurpleClick()
    {
        myColor = Purple;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Purple";
        colorConfirmationText.color = myColor;
    }

    public void onPinkClick()
    {
        myColor = Pink;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Pink";
        colorConfirmationText.color = myColor;
    }

    public void onDarkBlueClick()
    {
        myColor = DarkBlue;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Dark Blue";
        colorConfirmationText.color = myColor;
    }

    public void onBlackClick()
    {
        myColor = Black;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Black";
        colorConfirmationText.color = myColor;
    }

    public void onOrangeClick()
    {
        myColor = Orange;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Orange";
        colorConfirmationText.color = myColor;
    }

    public void onLimeClick()
    {
        myColor = Lime;
        colorConfirmationText = GameObject.Find("ColorConfirmText").GetComponent<Text>();
        colorConfirmationText.text = "Lime";
        colorConfirmationText.color = myColor;
    }

    public void onEasyClick()
    {
        easyButton = GameObject.Find("EasyButton").GetComponent<Button>();
        normalButton = GameObject.Find("NormalButton").GetComponent<Button>();
        hardButton = GameObject.Find("HardButton").GetComponent<Button>();
        easyButton.image.color = Green;//change difficulty color
        normalButton.image.color = Color.white;
        hardButton.image.color = Color.white;
        myDifficulty = Difficulty.easy;//set difficulty
    }

    public void onNormalClick()
    {
        easyButton = GameObject.Find("EasyButton").GetComponent<Button>();
        normalButton = GameObject.Find("NormalButton").GetComponent<Button>();
        hardButton = GameObject.Find("HardButton").GetComponent<Button>();
        normalButton.image.color = Yellow;
        easyButton.image.color = Color.white;
        hardButton.image.color = Color.white;
        myDifficulty = Difficulty.normal;
    }

    public void onHardClick()
    {
        easyButton = GameObject.Find("EasyButton").GetComponent<Button>();
        normalButton = GameObject.Find("NormalButton").GetComponent<Button>();
        hardButton = GameObject.Find("HardButton").GetComponent<Button>();
        hardButton.image.color = Red;
        normalButton.image.color = Color.white;
        easyButton.image.color = Color.white;
        myDifficulty = Difficulty.hard;
    }
    #endregion
}
