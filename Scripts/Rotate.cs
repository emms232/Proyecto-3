using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }
}
