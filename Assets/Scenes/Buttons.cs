using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

//in the class:

public void PlayGame()
{
    SceneManager.LoadScene(1); //scene number to be updated
}

public void QuitGame()
{
    Application.Quit();
}﻿

}
