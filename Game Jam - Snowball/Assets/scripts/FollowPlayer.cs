using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public Vector3 panning;

    private void Update()
    {
        Vector3 totOff = offset;
        if (Input.GetKey("a"))
        {
            totOff += panning; 
        }

        if (Input.GetKey("d"))
        {
            totOff -= panning;
        }

        transform.position = player.position + totOff;
    }

}
