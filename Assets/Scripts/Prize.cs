using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prize : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Prize", LoadSceneMode.Single);//We will load the scene named in the inspector it will be .Single because it will close the previous scene
    }

    
    public void ExitSoftware()
    {
        Application.Quit();
    }
}
