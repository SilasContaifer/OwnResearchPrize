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
    public bool politicalValue;
    [Header("UI text")]
    public Text politicalRightUI;
    public Text politicalLeftUI;

    //
    private int leftValue;//total value of answers from the Left Political spectrum
    private int rightValue;//total value of answers from the Right Political spectrum


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Show the Value of Political Value
        if (politicalValue)
        {
            //Load each value
            rightValue = PlayerPrefs.GetInt("RightValue");
            leftValue = PlayerPrefs.GetInt("LeftValue");
            //Change the text number informed in the screen
            politicalLeftUI.text = "L: " + leftValue.ToString();
            politicalRightUI.text = "R: " + rightValue.ToString();
        }
    }
}
