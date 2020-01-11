using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Variables

    /// <summary>
    /// Gloabl timer to keep track of time
    /// </summary>
    float g_timer;
    /// <summary>
    /// Timer before door is unlocked
    /// </summary>
    float g_lockTimer = 10f;

    /// <summary>
    /// Boolean used to determined if player filled victory conditions
    /// </summary>
    [SerializeField]
    bool g_gameEnd = false;

    /// <summary>
    /// Boolean used to check if player is dead
    /// </summary>
    [SerializeField]
    public bool g_playerDead = false;

    #endregion

    #region Base Methods
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (g_playerDead == true)
        {
            GameOver();
            
        }

        if (g_gameEnd == true)
        {
            Victory();
        }
    }

    private void FixedUpdate()
    {
        g_timer += Time.deltaTime;
        g_lockTimer -= Time.deltaTime;
        
        if (g_lockTimer <= 0)
        {
            Debug.Log("Door is open");
        }
    }

    #endregion

    #region Custom Methods

    /// <summary>
    /// Trigger game over events
    /// </summary>
    private void GameOver()
    {
        Debug.Log("Game Over");
    }

    /// <summary>
    /// Trigger victory events
    /// </summary>
    private void Victory()
    {
        Debug.Log("Victory");
    }

    #endregion
}
