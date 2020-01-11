<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [RequireComponent(typeof(WaterBase))]
    [ExecuteInEditMode]
    public class SpecularLighting : MonoBehaviour
    {
        public Transform specularLight;
        private WaterBase m_WaterBase;


        public void Start()
        {
            m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
        }


        public void Update()
        {
            if (!m_WaterBase)
            {
                m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
            }

            if (specularLight && m_WaterBase.sharedMaterial)
            {
                m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
            }
        }
    }
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [RequireComponent(typeof(WaterBase))]
    [ExecuteInEditMode]
    public class SpecularLighting : MonoBehaviour
    {
        public Transform specularLight;
        private WaterBase m_WaterBase;


        public void Start()
        {
            m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
        }


        public void Update()
        {
            if (!m_WaterBase)
            {
                m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
            }

            if (specularLight && m_WaterBase.sharedMaterial)
            {
                m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
            }
        }
    }
>>>>>>> cd5cf1ee40b60a8cc87daa3d731578051e238472
}