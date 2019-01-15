using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pause : MonoBehaviour {


    public static bool GameisPaused = false;
    public GameObject pauseMenu;
	public void Update ()
    {
        //when escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if game is already paused- resume
            if (GameisPaused)
            {
                Resume();
            }
            //if not pause, along with the music currently playing
            else
            {
                Pausing();
                transform.GetComponentInParent<AudioSource>().Pause();
            }

        }
    }
    public void Pausing()
    {
        //makes the pause menu active
        pauseMenu.SetActive(true);
        //pauses the processes of the game
        Time.timeScale = 0f;
        GameisPaused = true;
        //if there is an audio component, play music
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
    public void Resume()
    {
        //disables the pause menu
        pauseMenu.SetActive(false);
        //returnes the processes back to speed
        Time.timeScale = 1f;
        GameisPaused = false;
        //if there is an audio component stops it and makes its parent play instead
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Stop();
        }
        transform.GetComponentInParent<AudioSource>().Play();
    }
    public void Quit()
    {
        //exits the application
        Application.Quit();
    }
}
