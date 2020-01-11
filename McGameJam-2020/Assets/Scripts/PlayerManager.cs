using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int oxStorage = 100;
    public float oxLevel;
    private float oxLossRate = 1;

    private GameManager gm;
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        oxLevel = 100;
    }

    private void FixedUpdate()
    {
        if (oxLevel != 0)
        {
            oxLevel -= oxLossRate * Time.deltaTime;
        }
        else
        {
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

    private void Die()
    {
        gm.g_playerDead = true;
        Debug.Log("Player has died");
    }
}
