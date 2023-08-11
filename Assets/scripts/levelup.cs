using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour
{
    public GameObject tower;
    public GameObject cheese;
    public catStats cat;
    public Transform spawnposition;
    public float length;

    public void LevelUp()
    {
        Vector3 position= spawnposition.position;
        Quaternion rotation = spawnposition.rotation;
        if(cat.CanLevelUp()==true)
        {
            Instantiate(tower, position,rotation);   
            cheese.transform.SetPositionAndRotation(cheese.transform.position + new Vector3(0, length, 0), cheese.transform.rotation);
            increaseheight();
            cat.catnip -= 200;
        }
    }
    void increaseheight()
    {
        
        spawnposition.SetPositionAndRotation(spawnposition.position + new Vector3(0, length, 0), spawnposition.rotation*Quaternion.Euler(0,-25,0));
    }

}
