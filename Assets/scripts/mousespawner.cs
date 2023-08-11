using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousespawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mouse;
    private float spawnrate;
    float timer = 0;
    public GameObject spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;

        if (timer >= spawnrate)
        {
            spawnrate = Random.Range(2.0f, 5.0f);
            GameObject mouseClone= Instantiate(mouse,spawn.transform.position,spawn.transform.rotation);
            timer = 0;
            mouseClone.SetActive(true);
        }
    }
}
