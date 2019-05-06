using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This file controls the health of the first player.
 * The update function sets the updated health each time the 
 * first player is hit or its health decreases due to some other reason.*/

//health class for the methods and global variables
public class health2 : MonoBehaviour
{
    /*The public variable Slider takes in the element slider which is 
   * used as a health bar. The variable myPlayer is the first player. 
   * myHealth is the first player's health*/
    public Slider s;
    public player2 myPlayer;
    int myHealth;

    // Start is called before the first frame update
    void Start()
    {
        //nothing to be initialized in start 
    }

    // Update is called once per frame
    void Update()
    {
        /*updates the health every time the frame is loaded. the value of slider
        * is updated accordingly and displayed on the screen.
        * Note that the green area in slider represents the remaining health
        * while the red region is the Damage taken.*/
        myHealth = myPlayer.health;
        s.value = myHealth;

    }
}
