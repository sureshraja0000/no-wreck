using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectNext : MonoBehaviour
{
    public void RetryThisLevel()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
