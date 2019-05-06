using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script controls the animations of the first player.
 * including all themotions it exhibits . From punching to walking.
 * This also is responsible for decreasing the health when it receives
 * a hit from the othe player*/

public class player : MonoBehaviour
{
    /*The animator class constructs the fsm for animation
     * health is th eplayers health at any point of time
     * refresh is the number of frame that must lapse before the player 
     * does a second set of movements*/
    public Animator anim;
    public int health;
    int refresh=0;
    public bool attack = false;

    //position of th player in y as its moving in only one direction
    float y;
 
    Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        //setting the iitial values
        anim = GetComponent<Animator>();
        y = transform.position.y;             //because animations caused movement in this direction too
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //updating the position, helath each time
        p.y = y;
        anim.SetInteger("health", health);

        //this snippet controls the boundaryof the player within the game screen
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
        
        /*Settin gthe link between the motions and the keyboard keys
         * Different sets of keys have different functions*/

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
        4

            //the maximum value of refresh is 25
            //whixh means the user must wait for 25 
            //frames before doing another set of motions
        refresh++;
        if (refresh == 25)                          // so that multiple key presses can't be done at the same time
        {
            refresh = 0;
            attack = false;
        }
        
    }
}
