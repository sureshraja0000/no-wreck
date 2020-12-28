using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerActions : MonoBehaviour
{
   public void PlayCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
