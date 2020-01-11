using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class sphere : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;
    public Collider coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        coll.attachedRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    // move the object down the screen
    private void OnTriggerEnter(Collider other)
    {
        
        
        if (enter)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
    
}
