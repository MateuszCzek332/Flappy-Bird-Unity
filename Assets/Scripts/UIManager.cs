using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI scoretext;
    [SerializeField]private GameObject gameOverPanel;
    [SerializeField] private GameObject startPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.RegisterUI(this);
        scoretext.text = "";
    }

    public void UpdateScore(int newScore) {
        scoretext.text = newScore.ToString();
    }

    public void showGameOverScreen(){
        gameOverPanel.SetActive (true);
    }

    public void hideGameOverScreen()
    {
        gameOverPanel.SetActive(false);
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
