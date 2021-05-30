using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{

    public float[] position;

    public float[] campos;

    public int gold;

    public PlayerData(Player player)
    {


        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        campos = new float[3];
        campos[0] = player.transform.position.x;
        campos[1] = player.transform.position.y;
        campos[2] = player.transform.position.z;

    }

    


   
}
