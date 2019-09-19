using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public WallCollisionHandler wall;
    public LoadingBarController loadingBar;
    public string lostSceneName;
    public string wonSceneName;

    public static float runningTime;

    bool gameRunning;

    private void Start()
    {
        gameRunning = true;
        runningTime = 0;
        wall.barAndWallCollisionAction += looseGameScenario;
        loadingBar.gameFinished += winGameScenario;
    }

    private void Update()
    {
        if(gameRunning)
            runningTime += Time.deltaTime;

        print(runningTime);
    }

    void looseGameScenario()
    {
        gameRunning = false;
        SceneManager.LoadScene(lostSceneName);
    }

    void winGameScenario()
    {
        gameRunning = false;
        SceneManager.LoadScene(wonSceneName);
    }
}
