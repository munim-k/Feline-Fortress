
using UnityEngine;

public class catStats : MonoBehaviour
{
    public int catnip;
    public float health;
    public float maxHealth;
    public GameObject hitparticles;
    public healthbar healthbar;
    public bool CanLevelUp()
    {
        if(catnip>=200)
        {
            return true;
        }
        else return false;
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "mousebullet" || other.gameObject.name == "mousebullet(clone)")
    //    {
    //        this.health -= 10;
    //        Debug.Log("hit");
    //    }
    //}
    public void damage()
    {
        this.health -= 10;
        Debug.Log("damage");
        hitparticles.SetActive(true);
        Invoke("deactivate",1.0f);
        healthbar.decreaseSize();
    }
    private void deactivate()
    {
        hitparticles.SetActive(false);
    }
}
