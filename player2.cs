using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public Animator anim;
    int refresh = 0;
    int refreshTurn = 0;
    public Vector3 p; 
    float y;
    public int health;
   
    public bool attack = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        y = transform.position.y;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        p.y = y;
        anim.SetInteger("health", health);
        if (transform.position.z > 267.15f)
        {
            p.z = 267.15f;
        }
        else
        {
            p.z = transform.position.z;
        }
        p.x = transform.position.x;
        transform.position = p;
        if (Input.GetKey("left"))
        {
            anim.SetBool("W", true);
        }
        else
        {
            anim.SetBool("W", false);
        }
        if (Input.GetKey("right"))
        {
            anim.SetBool("S", true);
        }
        else
        {
            anim.SetBool("S", false);
        }
        if (Input.GetKey("9"))
        {
            anim.SetBool("block", true);
            attack = false;
        }
        else
        {
            anim.SetBool("block", false);
        }
        if (Input.GetKey(KeyCode.I) && refresh == 0)
        {
            anim.Play("hp_straight_A 0", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey("down") && refresh == 0)
        {
            anim.Play("JumpLoop", -1, 0f);
        }
        else if (Input.GetKey(KeyCode.O) && refresh == 0)
        {
            anim.Play("hp_straight_right_A", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey(KeyCode.K) && refresh == 0)
        {
            anim.Play("lk_rh_left_A", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey(KeyCode.L) && refresh == 0)
        {
            anim.Play("hk_rh_right_A", -1, 0f);
            attack = true;
        }

        refresh++;
        if (refresh == 25)
        {
            refresh = 0;
            attack = false;
        }
        refreshTurn++;
        if (refreshTurn == 60)
        {
            refreshTurn = 0;
        }
    }
}
