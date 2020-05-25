using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public StringReference sceneName;

    public void SwitchToScene()
    {
        SceneManager.LoadScene(sceneName.value, LoadSceneMode.Single);
    }

    public void AddScene()
    {
        SceneManager.LoadScene(sceneName.value, LoadSceneMode.Additive);
    }
}
