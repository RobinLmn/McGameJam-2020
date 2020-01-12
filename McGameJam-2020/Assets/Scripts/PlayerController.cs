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
    public float speed;
    private Light g_flashLight;
    NavMeshAgent g_player;
    public bool sprint = false;
    float horInput;
    float verInput;

    void Start()
    {
        //   motor = GetComponent<PlayerMotor>();
        mainCam = Camera.main; //taking the main camera
        g_flashLight = GetComponentInChildren<Light>();
        g_player = GetComponent<NavMeshAgent>();
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<CharacterAnimator>().isDead != true) { 

            if (platform==true) {
                float horInput = Input.GetAxis("Horizontal");
                float verInput = Input.GetAxis("Vertical");
                Vector3 movement = new Vector3(horInput, 0f, verInput);
                Vector3 moveDestination = transform.position + movement.normalized*speed;
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

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                sprint = true;
                horInput = horInput * 2;
                verInput = verInput * 2;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                sprint = false;
                horInput = horInput * 0.5f;
                verInput = verInput * 0.5f;
            }
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
