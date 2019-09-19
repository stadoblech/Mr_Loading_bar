using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OffGameChangeSceneHandler : MonoBehaviour
{
    public string gameSceneName;

    public void _changeScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
