using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        rb.AddForce(transform.forward * speed);
        Destroy(this.gameObject, 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
  
}