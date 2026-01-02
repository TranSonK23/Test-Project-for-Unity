using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject GameOverUI;
    private bool isOver = false;
    [SerializeField] private GameObject GameWinUI;
    private bool isWin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore(); 
        GameOverUI.SetActive(false);
        GameWinUI.SetActive(false);
    }

    // Update is called once per frame
    public void AddScore(int points)
    {
        if (!isOver && !isWin)
        {
            score += points;
            UpdateScore();
        }


    }
    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
    public void GameOver()
    {
        isOver = true;
        score = 0;
        Time.timeScale = 0;
        GameOverUI.SetActive(true);
    }
        public void GameWin()
    {
        isWin = true;
        Time.timeScale = 0;
        GameWinUI.SetActive(true);
    }
    public void RestartGame()
    {
        isOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public bool IsGameOver()
    {
        return isOver;
    }
    public bool IsGameWin()
    {
        return isWin;
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
