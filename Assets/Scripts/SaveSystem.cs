using UnityEngine;

public static class SaveSystem 
{
    private const string bestScoreKay = "bestscore";

    public static int GetBestScore()
    {
        return PlayerPrefs.GetInt(bestScoreKay, 0);
    }

    public static void SaveScore(int score)
    {
        int best = GetBestScore();
        if (score > best) { 
            PlayerPrefs.SetInt(bestScoreKay, score);
            PlayerPrefs.Save();
        }
    }
}
