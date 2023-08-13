using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class catniptext : MonoBehaviour
{
    TextMeshProUGUI ButtonText;
    public catStats catstats;
    public int upgraderequirement;
    public Button upgradebutton;
    void Start()
    {
        ButtonText = GetComponent<TextMeshProUGUI>();
        upgraderequirement = catstats.getupgraderequirements();
    }
    private void Update()
    {
        if(catstats.catnip<upgraderequirement)
        {
            upgradebutton.interactable = false;
        }
        else
        {
            upgradebutton.interactable = true;
        }
    }
}
