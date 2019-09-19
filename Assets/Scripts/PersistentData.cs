using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    #region clicks
    static string bestTimeTag = "BestTime";
    public static void initBestTime(float defaultC)
    {
        if (!PlayerPrefs.HasKey(bestTimeTag))
            PlayerPrefs.SetFloat(bestTimeTag, defaultC);
    }

    public static float getTime()
    {
        float l = PlayerPrefs.GetFloat(bestTimeTag);
        return l;
    }
    public static void setTime(float time)
    {
        PlayerPrefs.SetFloat(bestTimeTag, time);
    }
    #endregion

}
