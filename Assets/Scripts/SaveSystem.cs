using UnityEngine;

public static class SaveSystem 
{
    private const string bestScoreKay = "bestscore";
    private const string lastSelectedTheme= "lastTheme";

    public static int GetBestScore()
    {
        return PlayerPrefs.GetInt(bestScoreKay, 0);
    }

    public static int GetLastTheme()
    {
        return PlayerPrefs.GetInt(lastSelectedTheme, 0);
    }

    public static void SaveScore(int score)
    {
        int best = GetBestScore();
        if (score > best) { 
            PlayerPrefs.SetInt(bestScoreKay, score);
            PlayerPrefs.Save();
        }
    }

    public static void SaveTheme(int themeNumber)
    {
        PlayerPrefs.SetInt(lastSelectedTheme, themeNumber);
        PlayerPrefs.Save();    
    }
}
