using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManagerScript : MonoBehaviour

{

    // Start is called before the first frame update
    public GameObject baseMenu;
    public GameManager gm;
    public bool isHome = false;
    public GameObject message;

    public static BaseManagerScript instance;

    void Awake()
    {
        instance = this;
        message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (isHome)
       {
        //    if (gm.g_lockTimer < 0) {
                baseMenu.SetActive(true);
                Debug.Log("Kill Enemies");
                isHome = false;
                Time.timeScale = 0f;
        //    }
        //    } else {
        //        message.SetActive(true);
        //    }
       }
    }

   
}
