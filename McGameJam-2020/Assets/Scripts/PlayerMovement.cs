using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Serialize = can be changed in the inspector but is not public

    [SerializeField]
    public float speed;

    Vector3 forward, right;

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
    }

    void Update()
    {
        if (Input.anyKey)
            Move();
    }

    void Move()
    {
        // Define the directions
        Vector3 rightMovement = Time.deltaTime * right * speed * Input.GetAxis("Horizontal");
        Vector3 upMovement = Time.deltaTime * forward * speed * Input.GetAxis("Vertical");

        // movement
        transform.position += upMovement;
        transform.position += rightMovement;

    }
}
