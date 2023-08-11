using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class moveto : MonoBehaviour
{
    public int health = 20;
   
   
    private void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.tag == "bullet" || collision.gameObject.name == "bullet(clone)")
        {
            this.health -= 10;
         
        }
            
    }
  
    void destroymouse()
    {
        Destroy(this.gameObject);
    }
    
    private void FixedUpdate()
    {
                 
        if (this.health <= 0)
        {
            if (this.gameObject.tag == "mouse" && this.gameObject.name != "mouse")
            {
                destroymouse();
            }
        }
       
    }
    

}




    



