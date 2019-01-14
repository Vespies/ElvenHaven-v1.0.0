using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pause : MonoBehaviour {


    public static bool GameisPaused = false;
    public GameObject pauseMenu;
	public void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pausing();
                transform.GetComponentInParent<AudioSource>().Pause();
            }

        }
    }
    public void Pausing()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Stop();
        }
        transform.GetComponentInParent<AudioSource>().Play();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
