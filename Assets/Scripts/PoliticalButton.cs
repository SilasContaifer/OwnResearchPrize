using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliticalButton : MonoBehaviour
{

    /// <summary>
    /// Add this script to the each button that are an Answer to the Political Questions
    /// </summary>

    [Header("Select one of the following")]//Classify the button for this answer as it political focus
    public bool leftButton;
    public bool rightButton;
    //public bool centralButton; /*Saved here for a future implementation*/
    
    [Header("Question Value")]/*for our model each question has the same value, but for future version
                               questions could have diferent weights*/
    public int thisQuestionValue = 1;//value that will be add to the questions that will be separate into different political views
    
    //Hidden variables
    private int rightValue;//total value of answers from the Right Political spectrum
    private int leftValue;//total value of answers from the Left Political spectrum

    [Header("Question Value")]
    public string sceneName;//name of the scene that will be load after one of the answers are selected

    public void Answer()
    {
        //If the button pressed refered to a Political Right Answer
        if (rightButton)
        {
            rightValue = PlayerPrefs.GetInt("RightValue");//Receive the value saved up to now from the Right-wing questions
            PlayerPrefs.SetInt("RightValue", rightValue + thisQuestionValue);//Increse the total value after answering a question
            Advace();
        }
        //If the button pressed refered to a Political Left Answer
        else if (leftButton)
        {
            leftValue = PlayerPrefs.GetInt("LeftValue");//Receive the value saved up to now from the Left-wing questions
            PlayerPrefs.SetInt("LeftValue", leftValue + thisQuestionValue);//Increse the total value after answering a question
            Advace();
        }
        //else if (central) /*Saved here for a future implementation*/
    }
    void Advace()
    {
        //After a question is answered we will save the points
        PlayerPrefs.Save();
        //Load the next Scene (= advance to a new question or to the end of this quiz)
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);/*We will load the scene named in the inspector
                                                                 it will be .Single because it will close the previous scene*/
    }
}
