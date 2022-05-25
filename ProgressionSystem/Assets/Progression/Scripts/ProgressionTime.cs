using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionTime : ProgressionBase
{
    [SerializeField, Min(0f)] int time = 0;
    int h = 0, m = 0, s = 0;

    public override string ToString()
    {
        string hours, minutes, seconds;

        s = (time % 61);

        if (s == 60)
        {
            m = (m + 1 % 61);
        }

        if (m == 60)
        {
            h = (h + 1 % 61);
        }

        seconds = (s < 10) ? "0" + s : s.ToString();
        minutes = (m < 10) ? "0" + m : m.ToString();
        hours   = (h < 10) ? "0" + h : h.ToString();

        return hours + ":" + minutes + ":" + seconds;
    }

    public void Update()
    {
        time = (int)Time.time;
    }

    public override void Reset()
    {
        time = 0;
    }
}
