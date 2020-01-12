using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update

    public IEnumerator Shake(float time,float intensity)
   {
       Vector3 originalPos = transform.localPosition;
       float elapsedTime = 0f;

       while (elapsedTime < time)
       {
           float x = Random.Range(-1, 1) * intensity;
           float y = Random.Range(-1, 1) * intensity;

           transform.localPosition = new Vector3(x, y, x);
           elapsedTime += Time.deltaTime;

           yield return null;
       }

       transform.localPosition = originalPos;

   }

}
