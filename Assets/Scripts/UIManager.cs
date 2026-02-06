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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.RegisterUI(this);
        currentScoreText.text = "";
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

    public void startButtonOnClick()
    {
        GameManager.startGame();
    }

    public void restartButtonOnClick()
    {
        GameManager.restartGame();
    }
}
