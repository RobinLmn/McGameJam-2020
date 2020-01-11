using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    // private float barFull = 1.0f;
    public int max;
    private int currVal;
    public Image barImage;
    // Start is called before the first frame update
    void Start()
    {
        currVal = max;
    }

    // Update is called once per frame
    void Update()
    {
        changeBarHealth(-1);
        if (currVal < 0) 
            currVal = max;
        barImage.fillAmount = currVal * 1.0f / max;
        
    }

    public void changeBarHealth(int amt) {
        currVal += amt;
    }
}
