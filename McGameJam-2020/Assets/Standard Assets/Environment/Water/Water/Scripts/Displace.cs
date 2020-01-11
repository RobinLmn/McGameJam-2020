<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(WaterBase))]
    public class Displace : MonoBehaviour
    {
        public void Awake()
        {
            if (enabled)
            {
                OnEnable();
            }
            else
            {
                OnDisable();
            }
        }


        public void OnEnable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
        }


        public void OnDisable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
        }
    }
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(WaterBase))]
    public class Displace : MonoBehaviour
    {
        public void Awake()
        {
            if (enabled)
            {
                OnEnable();
            }
            else
            {
                OnDisable();
            }
        }


        public void OnEnable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
        }


        public void OnDisable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
        }
    }
>>>>>>> cd5cf1ee40b60a8cc87daa3d731578051e238472
}