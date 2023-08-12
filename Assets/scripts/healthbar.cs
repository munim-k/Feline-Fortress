using UnityEngine;

public class healthbar : MonoBehaviour
{
    RectTransform bar;
    float segment;
    private void Start()
    {
        bar = GetComponent<RectTransform>();
        segment = bar.rect.width/20f;
    }
    public void decreaseSize()
    {
        bar.rect.size.Set(bar.rect.width-segment,bar.rect.height);
        bar.rect.position.Set(bar.rect.x-segment,bar.rect.y);
    }

}
