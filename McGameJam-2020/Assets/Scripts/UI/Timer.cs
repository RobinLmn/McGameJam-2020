using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private int secondsLeft;
    public int timerStartVal;
    private float decrementTimer;
    public TextMeshProUGUI timerText;

    public GameManager gm;
     
    // Start is called before the first frame update
    void Start()
    {
       /* secondsLeft = timerStartVal;
        decrementTimer = 0.0f; */
    }

    // Update is called once per frame
    void Update()
    {
        /* decrementTimer += Time.deltaTime;
        if (decrementTimer > 1.0f) {
            decrementTimer -= 1.0f;
            this.Decrement();
            
        }
        */

        timerText.text = "" + (int) gm.g_lockTimer;

    }

    /* void Decrement() {
        secondsLeft--;


        //For testing only, resets timer back to max. Edit this  --Jen
        if (secondsLeft < 0) {
            secondsLeft = timerStartVal;
        }

        
        timerText.text = ""+secondsLeft; */
    
}
