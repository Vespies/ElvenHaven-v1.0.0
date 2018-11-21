using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{

	// Use this for initialization
	public void StartGame ()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
	}
	
	// Update is called once per frame
	public void EndGame ()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
