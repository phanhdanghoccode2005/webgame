using UnityEngine;

public class PlayerCollution : MonoBehaviour
{
    private GameManage gameManage;
    private AudioManager audioManage;
    private void Awake()
    {
        gameManage = FindAnyObjectByType<GameManage>();
        audioManage = FindAnyObjectByType<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            audioManage.PlayCoinSound();
            gameManage.AddScore(1);
            
        }
        else if (collision.CompareTag("Trap"))
        {
            gameManage.GameOver();
        }
        else if (collision.CompareTag("Enermy"))
        {
            gameManage.GameOver();
        }
        else if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            gameManage.GameWin();
        }

    }
}
