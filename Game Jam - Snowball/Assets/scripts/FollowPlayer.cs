using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float panningX;

    private void Update()
    {
        Vector3 panning;
        Vector3 totOff = offset;
       
        if (Input.GetKey("a"))
        {
            panning = new Vector3(panningX, 0,0);
            totOff += panning;
        }
        

        if (Input.GetKey("d"))
        {
            panning = new Vector3(-panningX,0,0);
            totOff += panning;
        }

        transform.position = player.position + totOff;
    }

}
