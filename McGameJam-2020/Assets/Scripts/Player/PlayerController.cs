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
    NavMeshAgent g_player;
    public bool sprint = false;
    public GameManager gm;
    float horInput;
    float verInput;

    private float messageTimer;
    private float messageTimeShown;

    float speed = 1;

    void Start()
    {
        //   motor = GetComponent<PlayerMotor>();
        mainCam = Camera.main; //taking the main camera
        g_flashLight = GetComponentInChildren<Light>();
        g_player = GetComponent<NavMeshAgent>();
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");

        messageTimeShown = 5.0f;
        messageTimer = messageTimeShown;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // gm.cantgobackMessage.SetActive(true)
        if (gm.cantgobackMessage.activeSelf) {
            messageTimer -= Time.deltaTime;
            if (messageTimer < 0) {
                gm.cantgobackMessage.SetActive(false);
                messageTimer = messageTimeShown;
            }

        }

        if (GetComponent<CharacterAnimator>().isDead == false) { 

        if (platform==true) {
            float horInput = Input.GetAxis("Horizontal");
            float verInput = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horInput, 0f, verInput) * speed;
            Vector3 moveDestination = transform.position + movement;
            GetComponent<NavMeshAgent>().destination = moveDestination;
        }
        else//platform is set to false
        {


            horInput = Input.GetAxis("Horizontal");
            verInput = Input.GetAxis("Vertical");
            //Mathf.Clamp(verInput, 0f, 1f);


            Vector3 movement = (transform.right * horInput + transform.forward * verInput) * speed;//transform.right* horInput+ transform.forward*verInput;
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
              speed = 2;
            }
         if (Input.GetKeyUp(KeyCode.LeftShift))
         {
             sprint = false;
             speed = 1;
         }
    
          Debug.Log(platform);
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


    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");

        if (other.gameObject.CompareTag("Base"))
        {
            Debug.Log("Enter base");
            if (gm.g_lockTimer < 0) {
                gm.cantgobackMessage.SetActive(false);

                BaseManagerScript.instance.isHome = true;
            } else {
                gm.cantgobackMessage.SetActive(true);
            }
        }
    }

}
