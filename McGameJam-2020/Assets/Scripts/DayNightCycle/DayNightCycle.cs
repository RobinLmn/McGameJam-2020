using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    #region Variables
    public bool pause = false;

    [Header("Time")]
    [Tooltip("Day Length in minutes")]
    [SerializeField]
    private float g_targetDayLength = 0.5f; //Length of the day
    public float dayLength
    {
        get
        {
            return g_targetDayLength;
        }
    }

    [SerializeField]
    [Range(0f, 1f)]
    private float g_timeOfDay;
    public float time
    {
        get
        {
            return g_timeOfDay;
        }
    }
    #endregion

    #region Methods


    #endregion

}
