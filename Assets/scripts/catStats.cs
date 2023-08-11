
using UnityEngine;

public class catStats : MonoBehaviour
{
    public int catnip;
    public float health;
    public float maxHealth;

    public bool CanLevelUp()
    {
        if(catnip>=200)
        {
            return true;
        }
        else return false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mousebullet" || other.gameObject.name == "mousebullet(clone)")
        {
            this.health -= 10;
            Debug.Log("hit");
        }
    }

}
