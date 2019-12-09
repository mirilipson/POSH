using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovment movement;     // A reference to our PlayerMovement script


    private void OnTriggerEnter2D(Collider2D other)
    {
        // We check if the object we collided with has a tag called "Obstacle".
            if (other.gameObject.CompareTag("Obstacle"))
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }


}
