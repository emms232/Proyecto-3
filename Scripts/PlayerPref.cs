using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{

    public GameObject Player;
    public float xPos;
    public float yPos;
    public float zPos;

    void Start()
    {
        xPos = PlayerPrefs.GetFloat("XPosition");
        yPos = PlayerPrefs.GetFloat("YPosition");
        zPos = PlayerPrefs.GetFloat("ZPosition");

        Player.transform.position = new Vector3(xPos, yPos, zPos);
    }

    void Update()
    {
        xPos = Player.transform.position.x;
        yPos = Player.transform.position.y;
        zPos = Player.transform.position.z;
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("XPosition", xPos);
        PlayerPrefs.SetFloat("YPosition", yPos);
        PlayerPrefs.SetFloat("ZPosition", zPos);

    }
}
