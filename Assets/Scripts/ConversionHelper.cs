using System;
using UnityEngine.UI;

public static class ConversionHelper
{
    public static string floatToTimeString(float time)
    {
        TimeSpan t = TimeSpan.FromSeconds(time);
        int milliseconds = t.Milliseconds / 10;
        //return string.Format("{0}:{1:00}", (int)time / 60,(int)time % 60);
        return string.Format("{0:D2}:{1:D2}.{2:00}",t.Minutes,t.Seconds,milliseconds);
    }

    public static Text UITextConverseNewLine(Text t)
    {
        Text tempT = t;
        t.text = t.text.Replace("\\n", "\n");
        return tempT;
    }
}

