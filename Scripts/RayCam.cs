using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour
{
    public GameObject player;
    private void FixedUpdate()
    {
        //Calculate the Vector direction 
        Vector3 direction = player.transform.position - transform.position;
        //Calculate the length
        float length = Vector3.Distance(player.transform.position, transform.position);
        //Draw the ray in the debug
        Debug.DrawRay(transform.position, direction.normalized * length, Color.red);


        
        //The first object hit reference
        RaycastHit currentHit;
        //Cast the ray and report the firt object hit filtering by "Wall" layer mask
        if (Physics.Raycast(transform.position, direction, out currentHit, length, LayerMask.GetMask("Wall")))
        {
            //Getting the script to change transparency of the hit object
            TransparentWall transparentWall = currentHit.transform.GetComponent<TransparentWall>();
            //If the object is not null
            if (transparentWall)
            {
                //Change the object transparency in transparent.
                transparentWall.ChangeTransparency(true);
            }
        }
    }

   
}
