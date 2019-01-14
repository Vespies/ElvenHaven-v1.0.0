
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);

    public static event SendScore OnSendScore;

    public int scoreToAdd = 10;
    private bool scoresent = false;

public void OnAddScore()
    {
       if (OnSendScore != null)
        {
            if (!scoresent)
            {
                scoresent = true;
                OnSendScore(scoreToAdd);
            }
        }
    }
}
