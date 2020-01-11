using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketItem : Interactable
{

    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }


    public override void Interact()
    {
        gm.invRocket++;
        base.Interact();
    }
}
