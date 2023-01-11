using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BestTime : MonoBehaviour
{
    public TextMeshProUGUI currentTime;
    public TextMeshProUGUI bestTime;
    void Start()
    {
        SetBestTime();
        SetCurrentTime();
    }

    public void SetBestTime()
    {
        bestTime.text = PlayerPrefs.GetInt("bestTime").ToString();
        int best = PlayerPrefs.GetInt("bestTime");
#if UNITY_WEBGL && !UNITY_EDITOR
    	            WebGLPluginJS.SetLeder(best);
#endif
    }
    public void SetCurrentTime()
    {
        currentTime.text = PlayerPrefs.GetInt("time").ToString();

    }
}
