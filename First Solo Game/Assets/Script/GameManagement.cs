using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    bool hasGameEnded = false;
    float restartTime = 1f;
    public GameObject levelCompleteUI;
    public GameObject levelRetryUI;
    public Transform player;
    public Text scoreText;
    public Text scoreRetryText;
    public PlayerMovement movement;

    public void EndGame()
    {
        if(hasGameEnded == false)
        {
            hasGameEnded = true;
            Invoke("RestartGame", restartTime);
        }
    }

    public void LevelSucess()
    {
        hasGameEnded = true;
        movement.enabled = false;
        levelCompleteUI.SetActive(true);
        scoreText.text = player.position.z.ToString("0");
    }

    public void RestartGame()
    {
        hasGameEnded = true;
        movement.enabled = false;
        levelRetryUI.SetActive(true);
        scoreRetryText.text = player.position.z.ToString("0");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RetryLevel()
    {
        Debug.Log("Retry Triggered");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
