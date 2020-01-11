<<<<<<< HEAD
using System;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public float multiplier = 1;

        private ParticleSystem[] m_Systems;


        private void Start()
        {
            m_Systems = GetComponentsInChildren<ParticleSystem>();
        }


        public void Extinguish()
        {
            foreach (var system in m_Systems)
            {
                var emission = system.emission;
                emission.enabled = false;
            }
        }
    }
}
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public float multiplier = 1;

        private ParticleSystem[] m_Systems;


        private void Start()
        {
            m_Systems = GetComponentsInChildren<ParticleSystem>();
        }


        public void Extinguish()
        {
            foreach (var system in m_Systems)
            {
                var emission = system.emission;
                emission.enabled = false;
            }
        }
    }
}
>>>>>>> cd5cf1ee40b60a8cc87daa3d731578051e238472
