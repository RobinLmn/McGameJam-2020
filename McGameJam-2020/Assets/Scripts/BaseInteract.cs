using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInteract : Interactable
{
    #region Variables

    GameManager gm;


    #endregion

    #region Base Methods
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    #endregion

    #region Custom Methods

    public override void Interact()
    {
        gm.g_gameEnd = true;
        base.Interact();
    }

    #endregion
}
