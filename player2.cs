using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public Animator anim;
    int refresh = 0;
    int refreshTurn = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
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
        if (Input.GetKey(KeyCode.I))
        {
            anim.SetBool("block", true);
        }
        else
        {
            anim.SetBool("block", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("A", true);
        }
        else
        {
            anim.SetBool("A", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("D", true);
        }
        else
        {
            anim.SetBool("D", false);
        }
        if (Input.GetKey(KeyCode.O) && refresh == 0)
        {
            anim.Play("hp_straight_A 0", -1, 0f);
        }

        else if (Input.GetKey(KeyCode.P) && refresh == 0)
        {
            anim.Play("hp_straight_right_A", -1, 0f);
        }
        else if (Input.GetKey(KeyCode.K) && refresh == 0)
        {
            anim.Play("lk_rh_left_A", -1, 0f);
        }
        else if (Input.GetKey(KeyCode.L) && refresh == 0)
        {
            anim.Play("hk_rh_right_A", -1, 0f);
        }

        refresh++;
        if (refresh == 40)
        {
            refresh = 0;
        }
        refreshTurn++;
        if (refreshTurn == 60)
        {
            refreshTurn = 0;
        }
    }
}
