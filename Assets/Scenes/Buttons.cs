using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

//in the class:

   // Reaction of the play button
public void PlayGame()
{
    SceneManager.LoadScene(1); //scene number to be updated
}

    //Reaction of the quit button
public void QuitGame()
{
    Application.Quit();
}﻿

}
