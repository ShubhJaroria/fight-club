using System;
using System.Collections.Generic;
using UnityEngine;

public class colliderp1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageHead;
    public int damageBody;
    public int damageLeg;
    public string name;
    public string owner;
    public player2 p2;
    public player p1;

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        colliderp1 c = other.gameObject.GetComponent<colliderp1>();
        
            if (c.owner == "p2" && p1.attack == true)
          {
            if (c.name == "head")
            {
                p2.health -= damageHead;
            }
               else if (c.name == "chest")
            {
                p2.health -= damageBody;
            }
               else if(c.name=="right leg" || c.name == "left leg")
            {
                p2.health -= damageLeg;
            }
          }
        if (c.owner == "p1" && p2.attack == true)
        {
            
            if (true)
            {
                p1.health -= damageHead;
            }
            else if (c.name == "chest")
            {
                p1.health -= damageBody;
            }
            else if (c.name == "right leg" || c.name == "left leg")
            {
                p1.health -= damageLeg;
            }
        }
    }
        
    
}
