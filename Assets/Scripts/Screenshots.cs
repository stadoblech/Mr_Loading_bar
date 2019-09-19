﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshots : MonoBehaviour
{
    public KeyCode screenshotKey = KeyCode.S;
    public float dynamicTime = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(screenshotKey))
        {
            ScreenCapture.CaptureScreenshot(createPath() + "_screen.png");
        }
        Time.timeScale = dynamicTime;
    }

    string createPath()
    {
        System.DateTime date = System.DateTime.Now;
        string file = Application.dataPath + "/screens/"+ date.Day + "_" + date.Month + "_" + date.Year + "_" + date.Hour + "_" + date.Minute + "_" + date.Second;
        return file;
    }
}
