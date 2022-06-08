// Kay M. - 6/8/2022
// MenuBehaviour gives functionality to the buttons in game.
// Attached this code to an empty game object and set in each objects inspector
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public void triggerMenuBehaviour(int i)
    {
        if (i == 0)
        {
            //Debug.Log("Start Button is clicked");
            SceneManager.LoadScene("Level"); 
        }
        if (i == 1)
        {
            //Debug.Log("Start Button is clicked");
            SceneManager.LoadScene("About"); 
        }
        if (i == 2)
        {
            //Debug.Log("Menu Button is clicked");
            SceneManager.LoadScene("Menu"); 
        }
    }
}