using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffGameChangeSceneHandler : MonoBehaviour
{
    public bool delayChange;

    public string gameSceneName;

    bool allowed;

    void Start()
    {
        if (delayChange)
            Invoke("allowToChange", 0.5f);
        else
            allowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (allowed && Input.anyKey && gameSceneName != "")
            SceneManager.LoadScene(gameSceneName);
    }

    void allowToChange()
    {
        allowed = true;
    }
}
