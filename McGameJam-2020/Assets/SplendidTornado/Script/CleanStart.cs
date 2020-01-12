using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanStart : MonoBehaviour
{
    public CameraShake camershake;
    public GameObject ParticleObj;
    public Transform player;
    private float distance;
    private float percentage;
    public float radius = 10f;
    public float multiplier = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Clean());
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.position-transform.position).magnitude<radius) {
            //shake the camera get out of here
            //if he is too close kill the player
            distance = (player.position - transform.position).magnitude;
            percentage = (radius - distance) / radius;
            if (percentage>0.3f) {
                PlayerManager.instance.Die();
            }
            else
            {
                float time = 0;
                
                StartCoroutine(camershake.Shake(percentage*multiplier, percentage*multiplier));//time than shake
                while (time < percentage * multiplier) {
                    time += Time.deltaTime;
                }

            }
            
            
        }
        
}

    IEnumerator Clean()
    {
        //ParticleObj.SetActive(true);
        //ParticleObj.SetActive(false);
        //print("Start");
        //yield return new WaitForSeconds(1f);
        //ParticleObj.SetActive(true);
        //print("StartActive");
        yield return new WaitForSeconds(0.01f);
        ParticleObj.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        ParticleObj.SetActive(true);
    }
    


}
