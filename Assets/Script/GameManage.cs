using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    private int score =0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject Rule;

    private bool isGameOver = false;
    private bool isWin = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        GameOverUI.SetActive(false);
        WinUI.SetActive(false);
        Rule.SetActive(true);

    }

    // Update is called once per frame
    
    public void AddScore(int points)
    {
        if (!isGameOver&&!isWin)
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
        isGameOver = true;
        score = 0;
        Time.timeScale = 0;
        GameOverUI.SetActive(true);
    }
    public void GameWin()
    {
        isWin = true;
        Time.timeScale = 0;
        WinUI.SetActive(true);
    }
    public void play()
    {
        Time.timeScale = 1;
        Rule.SetActive(false);

    }
    public void Restart()
    {
        isGameOver = false;
        score = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public bool IsGameOver()
    {
        return isGameOver;
    }
    public bool IsWin()
    {
        return isWin;
    }
    
}
