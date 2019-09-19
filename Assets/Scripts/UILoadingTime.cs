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
    }

    // Update is called once per frame
    void Update()
    {
        loadingTimeText.text = ConversionHelper.floatToTimeString(GameController.runningTime);
    }
}
