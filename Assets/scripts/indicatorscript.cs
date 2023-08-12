using UnityEngine;

public class indicatorscript : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite yellow;
    public Sprite orange;
    public Sprite red;
    float timer = 0;
    bool entered;
    public catStats cad;
    void change(int num)
    {
        if (num ==1)
        {
            spriterenderer.sprite = yellow;
        }
        if(num ==2)
        {
            spriterenderer.sprite=orange;
        }
        if(num==3)
        {
            spriterenderer.sprite=red;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cad" || other.gameObject.name == "Cad")
        {
            entered = true;   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Cad" || other.gameObject.name == "Cad")
        {
            timer = 0;
            entered = false;
            spriterenderer.gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        if(entered)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                change(3);
                cad.damage();
            }
            else if (timer > 1)
            {
                change(2);
            }
            else
            {
                change(1);
                spriterenderer.gameObject.SetActive(true);
            }
        }
    }
}
