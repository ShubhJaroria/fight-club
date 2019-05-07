using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderp1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageHead;              //damage to the head
    public int damageBody;              //damage to the body
    public int damageLeg;               //damage to the leg
    public string name;
    public int factor = 5;
    public string owner;
    public player2 p2;
    public player p1;

    // Update is called once per frame



    void OnTriggerEnter(Collider other)
    {
        colliderp1 c2 = other.gameObject.GetComponent<colliderp1>();        //get damage reciever's collider
        colliderp1 c1 = this.gameObject.GetComponent<colliderp1>();         //get giver's collider
        if (owner != c2.owner)
        {
            // Debug.Log(c2.gameObject.tag + " " + c1.gameObject.tag );             //debugging lol
        }
        if (c2.gameObject.tag == "player2" && gameObject.tag == "player" && p1.attack == true)  //damage is given only when attack animations are enabled
        {
            //Debug.Log(c.name);
            if (p2.blocked == false)            //no damage given when blocked
            {
                if (c2.name == "head" && p2.crouched == false)      //only kicking damage when crouched
                {
                    p2.health -= damageHead / factor;               //health reduced of reciever

                }
                else if (c2.name == "chest" && p2.crouched == false)
                {
                    p2.health -= damageBody / factor;
                }
                else if (c2.name == "right leg" || c2.name == "left leg")
                {
                    p2.health -= damageLeg / factor;
                }
            }
        }
        if (c2.gameObject.tag == "player" && gameObject.tag == "player2" && p2.attack == true)
        {
            if (p1.blocked == false)
            {
                if (c1.name == "head" && p1.crouched == false)
                {
                    p1.health -= damageHead / factor;
                }
                else if (c2.name == "chest" && p1.crouched == false)
                {
                    p1.health -= damageBody / factor;
                }
                else if (c2.name == "right leg" || c2.name == "left leg")
                {
                    p1.health -= damageLeg / factor;
                }
            }
        }
    }


}