using UnityEngine;

public static class GameManager
{
    static private bool gameOver = false;
    static private int score = 0;

    static public void UpdateScore(int points = 1)
    {
        score += points;
    }

    static public bool isGameOver() {
        return gameOver;
    }

    static public void setGameOver()
    {
        gameOver = true;
    }

}
