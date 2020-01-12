using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    private Quaternion start;
    void Start()
    {
        offset = transform.position;   
        start = Quaternion.Euler(transform.rotation.eulerAngles.x, 0f, transform.rotation.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = start;
        transform.position = new Vector3(player.transform.position.x, 200f, player.transform.position.z);
    }
}
