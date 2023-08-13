using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class moveto : MonoBehaviour
{
    public int health = 20;
    public GameObject particles;
    public GameObject currency;
    public catStats catStats;
    private void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.tag == "bullet" || collision.gameObject.name == "bullet(clone)")
        {
            this.health -= 10;
        }
            
    }
  
    void destroymouse()
    {
        Vector3 pos=this.gameObject.transform.position;
        Quaternion rot=this.gameObject.transform.rotation;  
        GameObject particle = Instantiate(particles, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject); 
        Destroy(particle, 0.5f);
        GameObject curr=Instantiate(currency, pos, rot);
        Destroy(curr, 1.5f);
        catStats.addcatnip();
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




    



