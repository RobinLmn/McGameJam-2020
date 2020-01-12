using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LaunchButton : MonoBehaviour
{
    public GameManager gm;
    public GameObject baseMenu;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (baseMenu.activeSelf) {
            if ( GetComponent<Button>().interactable == false && gm.invRocket >= 3) {
                GetComponent<Button>().interactable = true;
            }
        }
    }
}
