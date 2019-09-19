using UnityEngine;
using UnityEngine.UI;

public class WinController : MonoBehaviour
{
    public Text bestTimeText;
    public Text actualTimeText;
    public Text congratulationsText;

    float bestTime;
    float actualTime;

    void Start()
    {
        congratulationsText.enabled = false;
        PersistentData.initBestTime(200f);

        bestTime = PersistentData.getTime();
        actualTime = GameController.runningTime;

        bestTimeText.text = ConversionHelper.floatToTimeString(bestTime);
        actualTimeText.text = ConversionHelper.floatToTimeString(actualTime);
        if(actualTime < bestTime)
        {
            congratulationsText.enabled = true;
            PersistentData.setTime(bestTime);
        }

    }
}
