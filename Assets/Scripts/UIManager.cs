using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI scoretext;
    [SerializeField]private GameObject gameOverPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.RegisterUI(this);
        gameOverPanel.SetActive(false);
        scoretext.text = "";
    }

    public void UpdateScore(int newScore) {
        scoretext.text = newScore.ToString();
    }

    public void setGameOverScreen(){
        gameOverPanel.SetActive (true);
        Time.timeScale = 0f;
    }

    public void restartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.restart();
    }
}
