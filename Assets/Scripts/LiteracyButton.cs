using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiteracyButton : MonoBehaviour
{
    /// <summary>
    /// Add this script to the each botton that are an Answer to the Literacy Questions
    /// </summary>

    [Header("Question Value")]
    public int thisQuestionValue = 0;//value that will be add to the questions that will be separate into different Literacy levels
    private int literacyValue;//total value of answers from the Literacy Health question

    [Header("Name of the Scene that will be loaded")]
    public string sceneName;//name of the scene that will be load after one of the answers are selected

    public void Answer()
    {
        literacyValue = PlayerPrefs.GetInt("LiteracyValue");//Receive the value saved up to now from the Literacy questions
        PlayerPrefs.SetInt("LiteracyValue", literacyValue + thisQuestionValue);//Increse the total value after answering a question
        Advace();
    }
    void Advace()
    {
        //After a question is answered we will save the points
        PlayerPrefs.Save();
        //Load the next Scene = advance to a new question or to the end of this quiz
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);//We will load the scene named in the inspector it will be .Single because it will close the previous scene
    }

}
