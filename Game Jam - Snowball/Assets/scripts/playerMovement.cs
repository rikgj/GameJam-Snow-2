using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public Camera cam;
    public float forwardForce = 1000f;
    public float backwardForce = 700f;
    public float sidewaysForce = 150f;

    private bool moveLeft = false;
    private bool moveRight = false;
    private bool moveForward = false;
    private bool moveBackward = false;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (Input.GetKey("s"))
        {
            moveBackward = true;
        }
        else
        {
            moveBackward = false;
        }

        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        else
        {
            moveLeft = false;
        }

        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        else
        {
            moveRight = false;
        }

        if (Input.GetKey("r"))//restart
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void FixedUpdate()
    {
        //Vector3 direction = transform.position - cam.transform.position;
        //direction = new Vector3(direction.x, 0, direction.z);
        //direction.Normalize();

        if (moveForward)
        {
            rb.AddForce(0,0, forwardForce*Time.deltaTime);
            //rb.AddForce(direction * forwardForce*Time.deltaTime);
        }

        if (moveBackward)
        {
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime);
        }

        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0);
        }

        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
