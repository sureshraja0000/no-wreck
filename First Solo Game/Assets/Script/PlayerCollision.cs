using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public MeshRenderer mat;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            Color matColor = new Color(1f, 0f, 0f);
            movement.enabled = false;
            mat.material.color = matColor;
            FindObjectOfType<GameManagement>().EndGame();
        }

    }
}
