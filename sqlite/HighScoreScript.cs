using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public GameObject score;
    public GameObject scorename;
    public GameObject rank;

    public void SetScore(string name, string score, string rank)
    {
        this.rank.GetComponent<Text>().text = rank;
        this.score.GetComponent<Text>().text = score;
        this.scorename.GetComponent<Text>().text = name;
    }
}
