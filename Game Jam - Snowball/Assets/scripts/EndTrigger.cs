using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public PlayerMovement movement;

    void OnTriggerEnter()
    {
        movement.enabled = false;
        gameManager.CompleteLevel();
    }
}
