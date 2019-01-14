using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct HighScores
{
    public List<int> scores;
}
public class HighScoreUI : MonoBehaviour {
    public Text highscoreText;
    public HighScores highScore;
    private int totalHighScores=9;

	public void Start ()
    {
        int score = PlayerPrefs.GetInt("ScoreToAdd");
        string s = PlayerPrefs.GetString("HighScores");

        if (string.IsNullOrEmpty(s))
        {
            highScore = new HighScores();
            highScore.scores = new List<int>();
        }
        else
        {
            highScore = JsonUtility.FromJson<HighScores>(s);
        }
        if (highScore.scores.Count < totalHighScores)
        {
            int amount = totalHighScores - highScore.scores.Count;
            for (int i = 0; i < amount; i++)
            {
                highScore.scores.Add(0);
            }
        }
        if (score > highScore.scores[totalHighScores - 1])
        {
            highScore.scores[totalHighScores - 1] = score;
        }
        highScore.scores.Sort();
        highScore.scores.Reverse(0, totalHighScores);
        highscoreText.text = "HIGH SCORES\n";

        for (int i = 0; i < totalHighScores; i++)
        {
            if (highScore.scores[i] == score)
            {
                highscoreText.text += "<color=#FF0000FF>" + (i+1).ToString() + ". " + highScore.scores[i].ToString() + "</color>\n";
            }
            else
            {
                highscoreText.text += (i + 1).ToString() + ". " + highScore.scores[i].ToString() + "\n";
            }
        }
        string scoreJSON = JsonUtility.ToJson(highScore);
        PlayerPrefs.SetString("HighScores", scoreJSON);
	}
}
