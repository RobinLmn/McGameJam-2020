using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public bool bigView;
    public bool platform;
    public float givenHeight = 20f;
    public GameObject target;
    public PlayerController controller;

    public Vector3 offset;
    public Vector3 offset1;
    private Vector3 platOffset2;
    public Vector3 vector2;

    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    private float pitch = 10f; //to adjust the look at to be at the head of the player
    public float yawSpeed = 100f;

    public float currentZoom = 10f;
    private float horizontalYaw = 0f;

    void Start()
    {
        
        offset1 = new Vector3(0f, -1f, 5f);
        platOffset2 = new Vector3(0f, -5f, 0.2f);
        if (platform == true)
        {
            offset = platOffset2;
            controller.SetPlatform(true);
        }
        else {
            offset = offset1;
            controller.SetPlatform(false);
        }
            //offsetStored = offset;
           
    }

    void Update()//get the values from the scroll wheel
    {
        
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        horizontalYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;

    }
    // Update is called once per frame
    void LateUpdate()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Shake(.15f, .4f));
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.SwitchPlatform();
            Switch();
        }

        if (platform == true)
        {
            offset = platOffset2;
            if (bigView == true)
            {
                vector2.x = target.transform.position.x;
                vector2.z = target.transform.position.z;
                vector2.y = (float)givenHeight;
                transform.position = vector2 - offset * currentZoom;
                transform.LookAt(target.transform.position + Vector3.up * pitch);
                //transform.RotateAround(target.transform.position, Vector3.up, horizontalYaw);

            }
            else
            {
                transform.position = target.transform.position - offset * currentZoom;
                transform.LookAt(target.transform.position + Vector3.up * pitch);
                // transform.RotateAround(target.transform.position, Vector3.up, horizontalYaw);
            }
        }
        else {
        
           // controller.SetPlatform(false);
            //offset = offset1;
            //transform.position = target.transform.position - offset * currentZoom;
            //transform.position *= currentZoom;
             //transform.LookAt(target.transform.position + Vector3.up * pitch);
        }

    }
    
    void Switch() { // to switch the camera type

        if (platform == true)
        {
            platform = false;//you have to set the camera once and than it follows the player
            offset = offset1;
			Vector3 relback = target.transform.TransformDirection(Vector3.back);
			offset = offset + relback;
			transform.position = target.transform.position - offset * currentZoom;
            transform.LookAt(target.transform.position + Vector3.up * pitch);
        }
        else//false
        {
            platform = true;
            offset = platOffset2;
        }
    }

    /*public IEnumerator Shake(float time,float intensity)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsedTime = 0f;

        while (elapsedTime < time)
        {
            float x = Random.Range(-1, 1) * intensity;
            float y = Random.Range(-1, 1) * intensity;

            transform.localPosition = new Vector3(x, y, x);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;

    }*/



    
}
    
