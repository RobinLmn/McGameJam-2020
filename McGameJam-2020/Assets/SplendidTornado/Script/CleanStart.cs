using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanStart : MonoBehaviour
{

    public GameObject ParticleObj; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Clean());
    }

    // Update is called once per frame
    void Update()
    {
        
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
