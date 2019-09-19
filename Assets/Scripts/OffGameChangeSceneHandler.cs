using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OffGameChangeSceneHandler : MonoBehaviour
{
    public string gameSceneName;

    public bool loadAdOnButton;
    public float adProbability;

    public void _changeScene()
    {
        SceneManager.LoadScene(gameSceneName);

        if (loadAdOnButton)
            AdController.showLoadedAd(adProbability);
    }
}
