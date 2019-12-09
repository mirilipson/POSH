using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public PlayerMovment movement;
    private void OnTriggerEnter2D(Collider2D x)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (this.gameObject.CompareTag("nextLevel"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
