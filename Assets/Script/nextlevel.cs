using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    private string level;
   private void nextLevel()
    {
        SceneManager.LoadScene("level");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.CompareTag("Player"))
        {
            nextLevel();
        }
    }
}
