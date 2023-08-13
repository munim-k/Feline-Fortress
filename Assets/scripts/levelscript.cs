
using UnityEngine;
using UnityEngine.UI;

public class levelscript : MonoBehaviour
{
    Image LevelImage;
    public Sprite[] spritearray;
    int index=0;
    private void Start()
    {
        LevelImage= GetComponent<Image>();
    }
    public void Right()
    {
        index++;
        if(index>spritearray.Length-1)
        {
            index = 0;
        }
        LevelImage.sprite = spritearray[index];
    }
    public void Left()
    {
        index--;
        if(index<0)
        {
            index = spritearray.Length-1;
        }
        LevelImage.sprite = spritearray[index];
    }
}
