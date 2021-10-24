using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestingTools : MonoBehaviour
{
    /// <summary>
    /// For testing only - this function show text information in the screen 
    /// </summary>

    [Header("Value to Show on the Screen")]
    public bool showPoliticalValue;
    public bool showLiteracyValue;
    [Header("UI text")]
    public Text politicalRightUI;
    public Text politicalLeftUI;
    public Text literacyUI;

    //Values of the quizzes
    private int leftValue;//total value of answers from the Left Political spectrum
    private int rightValue;//total value of answers from the Right Political spectrum
    private int literacyValue;//total value of answers from the Literacy Health questions

    // Update is called once per frame
    void Update()
    {
        //Show the score of the Political Value
        if (showPoliticalValue)
        {
            //Load each value
            rightValue = PlayerPrefs.GetInt("RightValue");
            leftValue = PlayerPrefs.GetInt("LeftValue");
            //Change the text number informed in the screen
            politicalLeftUI.text = "L: " + leftValue.ToString();
            politicalRightUI.text = "R: " + rightValue.ToString();
        }

        //Show the score of the Literacy Value
        if (showLiteracyValue)
        {
            //Load the value
            literacyValue = PlayerPrefs.GetInt("LiteracyValue");//Receive the value saved up to now from the Literacy questions
            //Change the text number informed in the screen
            literacyUI.text = literacyValue.ToString();
        }
    }
}
