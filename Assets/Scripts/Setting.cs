using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{

    /// <summary>
    /// Add this script to the first Scene loded on this project
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        //Create the User variables
        PlayerPrefs.SetInt("LeftValue", 0);//It will storage the number*value of questions answered from the Left political side
        PlayerPrefs.SetInt("RightValue", 0);//It will storage the number*value of questions answered from the Right political side
        PlayerPrefs.SetInt("LiteracyValue", 0);//It will storage the number*value of questions answered from the Literacy questions

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
