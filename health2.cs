using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider s;
    public player2 myPlayer;
    int myHealth;
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        myHealth = myPlayer.health;
        s.value = myHealth;

    }
}
