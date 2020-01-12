using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	public static bool gameIsPaused;
	public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
		gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Toggle();
		}
        
    }

	public void Toggle() {
		if (gameIsPaused) Resume();
		else Pause();
	}

	public void Resume() {
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		gameIsPaused = false;
	}

	public void Pause() {
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		gameIsPaused = true;
	}
}
