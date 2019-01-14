using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider HealthBar;

    public Text ScoreText;

    public int playerScore = 0;

   private void OnEnable()
   {
       Player.OnUpdateHealth += UpdateHealthBar;

       AddScore.OnSendScore += UpdateScore;
   }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
        PlayerPrefs.SetInt("ScoreToAdd", playerScore);
    }
    private void UpdateHealthBar(int health)
    {
        HealthBar.value = health;
    }


    private void UpdateScore(int theScore)
    {
       playerScore += theScore;

        ScoreText.text = "SCORE: "+ playerScore.ToString();
    }
}
