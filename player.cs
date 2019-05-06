using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    public int health;
    int refresh=0;
    int refreshTurn = 0;
    public bool attack = false;
    float y;
 
    Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        y = transform.position.y;             //because animations caused movement in this direction too
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        p.y = y;
        anim.SetInteger("health", health);
        if(transform.position.z < 256.5f)
        {
            p.z = 256.5f;
        }
        else
        {
            p.z = transform.position.z;
        }
        p.x = transform.position.x;
        transform.position = p;
        
        if (Input.GetKey(KeyCode.G))
        {
            anim.SetBool("W", true);
        }
        else
        {
            anim.SetBool("W", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("S", true);
        }
        else
        {
            anim.SetBool("S", false);
        }
        if (Input.GetKey("1"))
        {
            anim.SetBool("block",true);
            attack = false;
        }
        else
        {
            anim.SetBool("block", false);
        }
        if (Input.GetKey(KeyCode.Q) && refresh == 0)
        {
            anim.Play("hp_straight_A 0", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey(KeyCode.F) && refresh == 0)
        {
            anim.Play("JumpLoop", -1, 0f);
        }
        else if (Input.GetKey(KeyCode.W) && refresh == 0)
        {
            anim.Play("hp_straight_right_A", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey(KeyCode.A) && refresh == 0)
        {
            anim.Play("lk_rh_left_A", -1, 0f);
            attack = true;
        }
        else if (Input.GetKey(KeyCode.S) && refresh==0)
        {
            anim.Play("hk_rh_right_A", -1, 0f);
            attack = true;
        }
        
        refresh++;
        if (refresh == 25)                          // so that multiple key presses can't be done at the same time
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
