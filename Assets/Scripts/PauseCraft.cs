using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCraft : MonoBehaviour
{
    public GameObject CraftPanel;
    public GameObject PausePanel;
    void Update()
    {

        if (CraftPanel.activeSelf || PausePanel.activeSelf)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;  
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
}
