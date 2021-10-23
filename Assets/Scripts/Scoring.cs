using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{

    //Values of the previous quizzes
    private int leftValue;//total value of answers from the Left Political spectrum
    private int rightValue;//total value of answers from the Right Political spectrum
    private int literacyValue;//total value of answers from the Literacy Health questions
    //Defined Position
    private bool isRight;
    private bool isLeft;
    private bool isCentre;
    private int literacyLevel;//the highest level the better
    [Header("Add the name of the Scenes for each type")]
    [Header("Right Political spectrum")]
    public string sceneRight01;
    public string sceneRight02;
    public string sceneRight03;
    [Header("Left Political spectrum")]
    public string sceneLeft01;
    public string sceneLeft02;
    public string sceneLeft03;
    [Header("Centre Political spectrum")]
    public string sceneCentre01;
    public string sceneCentre02;
    public string sceneCentre03;

    //Button to show Covid information based on the user classification
    public void FinalScore()
    {
        //Based on the test score it will save their value
        PoliticalScore();
        LiteracyScore();
        //Go to the correct scene
        Advace();

    }

    public void PoliticalScore()
    {
        //Load the results
        rightValue = PlayerPrefs.GetInt("RightValue");//Receive the value saved up to now from the Right-wing questions
        leftValue = PlayerPrefs.GetInt("LeftValue");//Receive the value saved up to now from the Left-wing questions
        //Define the Political position
        if (rightValue > leftValue)
        {
            isRight = true;
            isLeft = false;
            isCentre = false;
        }
        else if(rightValue < leftValue)
        {
            isRight = false;
            isLeft = true;
            isCentre = false;
        }
        else
        {
            isRight = false;
            isLeft = false;
            isCentre = true;
        }
    }

    public void LiteracyScore()
    {
        //Load the results
        literacyValue = PlayerPrefs.GetInt("LiteracyValue");//Receive the value saved up to now from the Literacy questions
        //Define the Literacy position
        if (literacyValue <= 10)
        {
            literacyLevel = 1;
        }
        else if (literacyValue > 10 & literacyValue <= 20)
        {
            literacyLevel = 2;
        }
        else
        {
            literacyLevel = 3;
        }
    }


    void Advace()
    {

        //Load the Scene based on the user answers
        //Left Political spectrum
        if (isLeft)
        {
            //We will load the scene named in the inspector it will be .Single because it will close the previous scene
            if (literacyLevel == 1)
            {
                SceneManager.LoadScene(sceneLeft01, LoadSceneMode.Single);
            }
            if (literacyLevel == 2)
            {
                SceneManager.LoadScene(sceneLeft02, LoadSceneMode.Single);
            }
            if (literacyLevel == 3)
            {
                SceneManager.LoadScene(sceneLeft03, LoadSceneMode.Single);
            }
        }
        //Right Political spectrum
        if (isRight)
        {
            //We will load the scene named in the inspector it will be .Single because it will close the previous scene
            if (literacyLevel == 1)
            {
                SceneManager.LoadScene(sceneRight01, LoadSceneMode.Single);
            }
            if (literacyLevel == 2)
            {
                SceneManager.LoadScene(sceneRight02, LoadSceneMode.Single);
            }
            if (literacyLevel == 3)
            {
                SceneManager.LoadScene(sceneRight03, LoadSceneMode.Single);
            }
        }
        //Centre Political spectrum
        if (isCentre)
        {
            //We will load the scene named in the inspector it will be .Single because it will close the previous scene
            if (literacyLevel == 1)
            {
                SceneManager.LoadScene(sceneCentre01, LoadSceneMode.Single);
            }
            if (literacyLevel == 2)
            {
                SceneManager.LoadScene(sceneCentre02, LoadSceneMode.Single);
            }
            if (literacyLevel == 3)
            {
                SceneManager.LoadScene(sceneCentre03, LoadSceneMode.Single);
            }
        }
    }
}
