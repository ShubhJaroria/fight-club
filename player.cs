using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("W", true);
        }
        else
        {
            anim.SetBool("W", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("S", true);
        }
        else
        {
            anim.SetBool("S", false);
        }
    }
}
