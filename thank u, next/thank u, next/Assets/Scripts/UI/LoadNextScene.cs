using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    private int nextSceneToLoad;
    private int prevSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.timeScale);
        
    }

    public void loadNext() {
        Debug.Log("Loaded next scene");
        SceneManager.LoadScene(nextSceneToLoad);
        Time.timeScale = 1.0f;
    }

    public void loadPrev() {
        SceneManager.LoadScene(prevSceneToLoad);
    }
}
