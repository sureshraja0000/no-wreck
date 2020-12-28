using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameManagement gameManagement;
    void OnTriggerEnter()
    {
        gameManagement.LevelSucess();
    }

}
