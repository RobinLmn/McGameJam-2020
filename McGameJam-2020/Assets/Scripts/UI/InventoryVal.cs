using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class InventoryVal : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameManager gm;
    public string suffix;

    // Update is called once per frame
    void Update()
    {
        text.text = gm.invRocket+ "" + suffix;
    }
}
