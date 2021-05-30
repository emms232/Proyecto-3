using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    private GameMaster gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    
    void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            Destroy(collision.gameObject);
            gm.Highscore += 1;
            ScoreText.coinAmount += 1;
        }
    }
}
