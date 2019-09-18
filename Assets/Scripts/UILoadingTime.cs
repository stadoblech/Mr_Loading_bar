using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoadingTime : MonoBehaviour
{
    Text loadingTimeText;

    void Start()
    {
        loadingTimeText = GetComponent<Text>();
        loadingTimeText.text = GameController.runningTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
