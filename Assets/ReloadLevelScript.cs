using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevelScript : MonoBehaviour
{
    public GameObject pause_label;

    public void LoadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scroller_GameWindow");
    }

    public void PauseLevel()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pause_label.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pause_label.SetActive(false);
        }
    }

}
