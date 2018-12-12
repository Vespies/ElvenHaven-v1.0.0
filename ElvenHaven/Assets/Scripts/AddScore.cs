
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);

    public static event SendScore OnSendScore;

    public int scoreToAdd = 1;

private void OnDestroy()
    {
       if (OnSendScore != null)
        {
            OnSendScore(scoreToAdd);
        }
    }
}
