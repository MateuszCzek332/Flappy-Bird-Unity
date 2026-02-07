using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    static private bool gameOver = false;
    static private int score = 0;
    
    static private UIManager ui;

    public static void RegisterUI(UIManager uiManager)
    {
        ui = uiManager;
        ui.showStartPanel();
        Time.timeScale = 0f;
    }

    public static void startGame() {
        setStartStats();
        Time.timeScale = 1f;
        ui.hideStartPanel();
    }
    static public void UpdateScore(int points = 1)
    {
        score += points;
        ui.UpdateScore(score);
    }

    private static void setStartStats() {
        gameOver = false;
        score = 0;
    }

    static public bool isGameOver()
    {
        return gameOver;
    }

    static public void GameOver()
    {
        gameOver = true;
        ui.showGameOverScreen(score);
        SaveSystem.SaveScore(score);
        Time.timeScale = 0f;

    }

    public static void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        setStartStats();
        Time.timeScale = 1f;
        ui.UpdateScore(score);
        ui.hideStartPanel();
        ui.hideGameOverScreen();
    }

}
