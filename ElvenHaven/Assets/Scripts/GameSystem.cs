using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
	public void StartGame ()
    {
        //loads the scene
        SceneManager.LoadScene("Zombie Shooter Level 1");
	}
	
	public void EndGame ()
    {
        //loads the scene and plays audio if attached
        SceneManager.LoadScene("Game Over");
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
    public void BackToMenu()
    {
        //unpauses the game, loads the scene and plays audio if attached
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
    public void Exit()
    {
        //exits the application
        Application.Quit();
    }
}
