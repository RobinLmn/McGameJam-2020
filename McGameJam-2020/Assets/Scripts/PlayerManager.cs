using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int oxStorage = 100;
    public float oxLevel;
    private float oxLossRate = 1;

    public Bar ox_bar;

    [SerializeField]
    private GameManager gm;
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
        if (gm == null)
        {
            gm = FindObjectOfType<GameManager>();
        }

        oxLevel = oxStorage;
    }

    private void Start()
    {
        ox_bar.max = oxStorage;
        gm = FindObjectOfType<GameManager>();
        oxLevel = oxStorage;
    }

    private void FixedUpdate()
    {
        if (oxLevel >= 0)
        {
            oxLevel -= oxLossRate * Time.deltaTime;
            ox_bar.currVal = oxLevel;
        }
        else
        {
            Debug.Log(" no more oxygen" );
            Die();
        }
    }

    private void Update()
    {
       if (oxLevel > oxStorage)
        {
            Debug.Log("Maximum Oxygen Capacity");
            oxLevel = oxStorage;
        }
    }

    public void Die()
    {
        gm.kill();
        Debug.Log("Player has died");
    }
}
