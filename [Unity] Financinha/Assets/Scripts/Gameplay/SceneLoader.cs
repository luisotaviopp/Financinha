using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour  
{
    public static int refLevel;
    public SceneLoader sceneLoader;
    private void Awake()
    {
        if(sceneLoader == null)
        {
            sceneLoader = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void LoadScene(int scene = 0)
    {
        scene = refLevel;
        SceneManager.LoadSceneAsync(scene);
    }
}
