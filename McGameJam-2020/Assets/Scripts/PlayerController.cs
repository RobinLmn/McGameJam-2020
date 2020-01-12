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
    private bool platform = false;
    public float rotatingSpeed;
    private Light g_flashLight;

    void Start()
    {
        //   motor = GetComponent<PlayerMotor>();
        mainCam = Camera.main; //taking the main camera
        g_flashLight = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
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
			Debug.Log(horInput);
			//transform.Rotate(Vector3.up* horInput *rotatingSpeed*Time.deltaTime);
			GetComponent<Rigidbody>().AddTorque(transform.up * rotatingSpeed * horInput);

        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            g_flashLight.enabled = !g_flashLight.enabled;
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
