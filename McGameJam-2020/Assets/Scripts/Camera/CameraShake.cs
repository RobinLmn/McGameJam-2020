using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform parent;

    public IEnumerator Shake(float time,float intensity)
   {
    
       Vector3 originalPos =parent.localPosition;
       float elapsedTime = 0f;

       while (elapsedTime < time)
       {
           float x = Random.Range(-1, 1) * intensity;
           float y = Random.Range(-1, 1) * intensity;
           float z = Random.Range(-1, 1) * intensity;

           parent.localPosition = new Vector3(x, y, originalPos.z);
           elapsedTime += Time.deltaTime;

           yield return null;
       }

       parent.localPosition = originalPos;

   }

}
