using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System;

public class HSManager : MonoBehaviour
{

    private string connectString;

    private List<Highscore> highscores = new List<Highscore>();

    public GameObject scorePrefab;

    public Transform scoreParent;

    void Start()
    {
      //connectString = "URI=file:" + Application.dataPath + "/HighscoreData.sqlite";


        connectString = "URI=file:" + Application.dataPath + "/HighscoreData.sqlite";

        //GetScores();

        ShowScore();
    }


    /*
    private void InsertScore(string name, int newScore)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = name.ToString("INSERT INTO Highscore(name, score) VALUES(\"{0}\",\"{1}\")", newScore);


                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();

                
            }
        }
    }
    */
    private void GetScores()
    {

        highscores.Clear();

        using (IDbConnection dbConnection=new SqliteConnection(connectString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM Highscore";

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        highscores.Add(new Highscore(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1)));
                    }
                }
            }
        }
    }

    private void DeleteScore(int id)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                const string Format = "DELETE FROM Highscore WHERE id = \"{{0}}\"";
                string sqlQuery = id.ToString(format: Format);

                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();


            }
        }
    }

    private void ShowScore()
    {
        GetScores();

        for (int i = 0; i < highscores.Count; i++)
        {
            GameObject tmpObject = Instantiate(scorePrefab);

            Highscore tmpScore= highscores[i];

            tmpObject.GetComponent<HighScoreScript>().SetScore(tmpScore.Name, tmpScore.Score.ToString(), "#" + (i + 1).ToString());

            tmpObject.transform.SetParent(scoreParent);
        }
    }
}
