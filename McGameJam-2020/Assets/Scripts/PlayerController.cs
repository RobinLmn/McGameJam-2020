using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject player;
    //PlayerMotor motor;
    Camera mainCam;
    private bool platform = true;
    public float rotatingSpeed;

    void Start()
    {
        //   motor = GetComponent<PlayerMotor>();
        mainCam = Camera.main; //taking the main camera
    }

    // Update is called once per frame
    void Update()
    {

        if (platform==true) {
            float horInput = Input.GetAxis("Horizontal");
            float verInput = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horInput, 0f, verInput);
            Vector3 moveDestination = transform.position + movement;
            GetComponent<NavMeshAgent>().destination = moveDestination;
        }
        else//platform is set to false
        {


            float horInput = Input.GetAxis("Horizontal");
            float verInput = Input.GetAxis("Vertical");
            //Mathf.Clamp(verInput, 0f, 1f);


            Vector3 movement = transform.right * horInput + transform.forward * verInput ;//transform.right* horInput+ transform.forward*verInput;
            Vector3 moveDestination = transform.position + movement;
            GetComponent<NavMeshAgent>().destination = moveDestination;
            transform.Rotate(Vector3.up* horInput *rotatingSpeed*Time.deltaTime);

        }
    }

    public void SetPlatform(bool boo)
    {
        if (boo == true)
        {
            platform = true;
        }
        else {
            platform = false;
        }
    }

    public void SwitchPlatform()
    {
        if (platform == true)
        {
            platform = false;
        }
        else
        {
            platform = true;
        }
    }


}
