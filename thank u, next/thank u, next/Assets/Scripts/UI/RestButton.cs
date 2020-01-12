using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestButton : MonoBehaviour
{

    public GameObject baseMenu;
    public GameManager gm;

    public void OnRest()
    {
        PlayerManager.instance.oxLevel = PlayerManager.instance.oxStorage;
        if (baseMenu.activeSelf)
        {
            baseMenu.SetActive(false);
            gm.g_lockTimer = 60f;
            Time.timeScale = 1f;
        }
    }
}
