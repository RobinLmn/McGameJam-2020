using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* From https://www.youtube.com/watch?v=LbDQHv9z-F0
 * Filmstorm
 */

public class Camerafollow : MonoBehaviour
{

    public float cameraSpeed = 120.0f;
    public float clampAngle = 80f;
    public float Sensitivity = 150f;

    public float Xdist;
    public float Ydist;
    public float Zdist;

    public float mouseX;
    public float mouseY;

    public float finalX;
    public float finalY;

    public float smoothX;
    public float smoothY;

    public GameObject camerBase;
    public GameObject player;

    Vector3 followPosition;
    
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;

        // To lock the cursor and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        
    }
}
