<<<<<<< HEAD
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad(string sceneName)
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

=======
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad(string sceneName)
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

>>>>>>> cd5cf1ee40b60a8cc87daa3d731578051e238472
