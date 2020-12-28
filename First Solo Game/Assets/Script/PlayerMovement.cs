using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float forwarForce = 2000f;
    public float sideForce = 80f;
    public float turn = 15f;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwarForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            var focusChange = new Vector3(0, turn, 0) * Time.deltaTime;

            player.transform.Rotate(focusChange);
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var focusChange = new Vector3(0, -turn, 0) * Time.deltaTime;

            player.transform.Rotate(focusChange);
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }


        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManagement>().EndGame();
        }
    }

   
}
