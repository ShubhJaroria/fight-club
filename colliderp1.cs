using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderp1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageHead;
    public int damageBody;
    public int damageLeg;
    public string name;
    public int factor = 5;
    public string owner;
    public player2 p2;
    public player p1;

    // Update is called once per frame
    


    void OnTriggerEnter(Collider other)
    {
        colliderp1 c2 = other.gameObject.GetComponent<colliderp1>();
        colliderp1 c1 = this.gameObject.GetComponent<colliderp1>();
       if (owner != c2.owner)
        {
           // Debug.Log(c1.owner + "'s " + c1.name + " hit " + c2.owner + "'s " + c2.name);
        }
            if (c2.gameObject.tag == "player2" && gameObject.tag == "player" && p1.attack == true)
          {
            //Debug.Log(c.name);
            if (c2.name == "head")
            {
                p2.health -= damageHead/factor;
                
            }
               else if (c2.name == "chest")
            {
                p2.health -= damageBody/factor;
            }
               else if(c2.name=="right leg" || c2.name == "left leg")
            {
                p2.health -= damageLeg/factor; 
            }
          }
        if (c2.owner == "p1" && p2.attack == true)
        {
            
            if (true)
            {
                p1.health -= damageHead/factor;
            }
            else if (c2.name == "chest")
            {
                p1.health -= damageBody/factor;
            }
            else if (c2.name == "right leg" || c2.name == "left leg")
            {
                p1.health -= damageLeg/factor;
            }
        }
    }
        
    
}
