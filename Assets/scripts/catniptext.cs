using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class catniptext : MonoBehaviour
{
    TextMeshProUGUI ButtonText;
    public catStats catstats;
    void Start()
    {
        ButtonText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        ButtonText.text = catstats.catnip.ToString() + "/200";
    }
}
