using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Destination;
    public Transform player;
    public Transform Cam;
    public Transform camloc;

    public void OnTriggerEnter(Collider other)
    {
        player.transform.position = Destination.transform.position;

        Cam.transform.rotation = camloc.transform.rotation;
        Cam.transform.position = camloc.transform.position;
    }
}
