using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI gameScoreText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject bestScoreMassage;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject themeSelectionPanel;

    [SerializeField] private int selectedTheme = 0;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.RegisterUI(this);
        currentScoreText.text = "";
        selectedTheme = SaveSystem.GetLastTheme();
    }

    public void UpdateScore(int newScore) {
        currentScoreText.text = newScore.ToString();
    }

    public void showGameOverScreen(int gameScore){
        gameOverPanel.SetActive (true);
        gameScoreText.text = gameScore.ToString();
        if(gameScore> SaveSystem.GetBestScore())
            bestScoreMassage.SetActive(true);
    }

    public void hideGameOverScreen()
    {
        gameOverPanel.SetActive(false);
        bestScoreMassage.SetActive (false);
        gameScoreText.text = "";
    }

    public void showStartPanel()
    {
        startPanel.SetActive(true);
    }

    public void hideStartPanel()
    {
        startPanel.SetActive(false);
    }

    public void showThemeSelectionPanel()
    {
        themeSelectionPanel.SetActive(true);
    }

    public void hideThemeSelectionPanel()
    {
        themeSelectionPanel.SetActive(false);
    }

    public void selectTheme(int themeNumber) {
        if (themeNumber < 0)
            return;

        selectedTheme = themeNumber;
        SaveSystem.SaveTheme(selectedTheme);
    }

    public void startButtonOnClick()
    {
        GameManager.startGame(selectedTheme);
    }

    public void restartButtonOnClick()
    {
        GameManager.restartGame();
    }
}
