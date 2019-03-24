using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            rb.AddForce(500,1000,300);
            rb.useGravity = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
