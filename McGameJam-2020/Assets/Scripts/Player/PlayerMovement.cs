using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Serialize = can be changed in the inspector but is not public

    [SerializeField]
    public float speed;
    private float sprintSpeed;

    Vector3 forward, right;
    Vector3 rightMovement;
    Vector3 upMovement;

    #region Singleton

    public static PlayerMovement instance;
    public GameObject player;


    private void Awake()
    {
        instance = this;
    }

    #endregion

    void Start()
    {
        // Calibrate forward on camera's axis
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        // Right vector is the perp vector to forward : 
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        sprintSpeed = speed * 10f;
    }

    void Update()
    {
        if (Input.anyKey)
            Move();
    }

    void Move()
    {
        

        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeed = speed * 10f;
            // Define the directions
            rightMovement = Time.deltaTime * right * sprintSpeed * Input.GetAxis("Horizontal");
            upMovement = Time.deltaTime * forward * sprintSpeed * Input.GetAxis("Vertical");
        }
        else
        {
            // Define the directions
            rightMovement = Time.deltaTime * right * speed * Input.GetAxis("Horizontal");
            upMovement = Time.deltaTime * forward * speed * Input.GetAxis("Vertical");
            
        }

        // movement
        transform.position += upMovement;
        transform.position += rightMovement;

    }
}
