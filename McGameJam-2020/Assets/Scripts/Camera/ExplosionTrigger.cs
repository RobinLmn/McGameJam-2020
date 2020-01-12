using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public CameraShake camershake;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){

            StartCoroutine(camershake.Shake(1,1));
        }    
    }
}
