using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int oxStorage = 100;
    public float oxLevel;
    private float oxLossRate = 1;
    private int sprintLossRate = 2;
    PlayerController controller;

    public Bar ox_bar;

    private GameManager gm;
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
        controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        ox_bar.max = oxStorage;
        gm = FindObjectOfType<GameManager>();
        oxLevel = oxStorage;
    }

    private void FixedUpdate()
    {
        if (oxLevel >= 0 && controller.sprint == false)
        {
            oxLevel -= oxLossRate * Time.deltaTime;
            ox_bar.currVal = oxLevel;
        }
        else if (oxLevel >= 0 && controller.sprint == true)
        {
            oxLevel -= sprintLossRate * Time.deltaTime;
            ox_bar.currVal = oxLevel;
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

    public void Die()
    {
        gm.g_playerDead = true;
        Debug.Log("Player has died");
    }
}
