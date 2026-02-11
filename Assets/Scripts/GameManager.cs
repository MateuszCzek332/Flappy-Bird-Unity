using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    static private bool gameOver = false;
    static private int score = 0;
    
    static private UIManager ui;
    static private AudioManager audio;
    static private Spawner spawner;

    public static void RegisterUI(UIManager uiManager)
    {
        ui = uiManager;
        ui.showStartPanel();
        Time.timeScale = 0f;
    }

    public static void RegisterAudio(AudioManager audioManager)
    {
        audio = audioManager;
    }

    public static void RegisterSpawner(Spawner Spawner)
    {
        spawner = Spawner;
    }

    public static void startGame() {
        setStartStats();
        Time.timeScale = 1f;
        ui.hideStartPanel();
        audio.playBackgroundMusic();
        spawner.selectPipe(2);
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
        audio.stopbackgroundMusic();
        audio.playDeathSound();
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
