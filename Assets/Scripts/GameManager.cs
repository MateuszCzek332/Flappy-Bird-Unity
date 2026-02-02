using Unity.VisualScripting;
using UnityEngine;

public class GameManager
{
    static private bool gameOver = false;
    static private int score = 0;
    
    static private UIManager ui;
    public static void RegisterUI(UIManager uiManager)
    {
        ui = uiManager;
    }

    public static void restart()
    {
        gameOver = false;
        score = 0;
    }
    static public void UpdateScore(int points = 1)
    {
        score += points;
        ui.UpdateScore(score);
    }

    static public bool isGameOver() {
        return gameOver;
    }

    static public void setGameOver()
    {
        gameOver = true;
        ui.setGameOverScreen();
    }

}
