<<<<<<< HEAD
using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
>>>>>>> cd5cf1ee40b60a8cc87daa3d731578051e238472
