
using UnityEngine;

public class catStats : MonoBehaviour
{
    public int catnip;
    public float health;
    public float maxHealth;
    public GameObject hitparticles;
    public healthbar healthbar;
    public int upgraderequirement=50;
    public bool CanLevelUp()
    {
        if(catnip>=upgraderequirement)
        {
            return true;
        }
        else return false;
    }
    private void Start()
    {
        catnip = 0;
        maxHealth = 200;
    }
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
    public void addcatnip()
    {
        catnip += 10;
    }
    public int getupgraderequirements()
    {
        return upgraderequirement;
    }
}
