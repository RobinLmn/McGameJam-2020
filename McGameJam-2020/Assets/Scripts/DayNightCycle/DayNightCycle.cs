using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    #region Variables

    /// <summary>
    /// A complete circle angle
    /// </summary>
    private const int ROUND = 360;
    [SerializeField]
    private const float BASEINTENSITY = 1;

    [SerializeField]
    private const float VARIATION = 1.5f;

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


    [Header("Sun Light")]
    [SerializeField]
    private Transform g_sunRotation;
    private float g_timeScale;

    [SerializeField]
    private Light g_sun;

    /// <summary>
    /// Mesure intensity of the sunlight
    /// </summary>
    private float g_intensity;

    [SerializeField]
    private Gradient g_sunColour;
    
    #endregion

    #region Base Methods

    private void Update()
    {
        if (pause != true)
        {
            //UpdateTimeScale();
            UpdateTime();

            SunRotation();
            SunIntensity();
            AdjustColour();
        }
    }

    #endregion


    #region Custom Methods

    /// <summary>
    /// Allows to convert real time to game time
    /// </summary>
    private float UpdateTimeScale()
    {
        g_timeScale = 24 / (g_targetDayLength / 60);
        return g_timeScale;
    }

    private void UpdateTime()
    {
        g_timeOfDay += Time.deltaTime * UpdateTimeScale() / 86400;

        if (g_timeOfDay > 1)
        {
            g_timeOfDay = 0;

        }
    }

    /// <summary>
    /// Manage the sun rotation according to day time
    /// </summary>
    private void SunRotation()
    {
        float m_sunAngle = time * ROUND;
        g_sunRotation.transform.rotation = Quaternion.Euler(new Vector3(m_sunAngle, 0, 0));
    }

    /// <summary>
    /// Manage and Calculate sun intensity
    /// </summary>
    private void SunIntensity()
    {
        g_intensity = Vector3.Dot(g_sun.transform.forward, Vector3.down);
        g_intensity = Mathf.Clamp01(g_intensity);

        g_sun.intensity = g_intensity * VARIATION + BASEINTENSITY;
    }

    /// <summary>
    /// Adjust sun colour
    /// </summary>
    private void AdjustColour()
    {
        g_sun.color = g_sunColour.Evaluate(g_intensity);
    }
    #endregion

}
