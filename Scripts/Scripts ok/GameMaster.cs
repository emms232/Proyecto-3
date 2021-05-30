using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections.Generic.List;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector3 lastCheckPoint;
    public int Highscore;



    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);

            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /*
     string namesOfDestroyedObjects;
    List<namesOfDestroyedObjects> NamesOfDestroyedObjects = new List<NamesOfDestroyedObjects>();

    void Start()
    {
        

        if (NamesOfDestroyedObjects.Count > 0)
        {

            for (int i = 0; i < NamesOfDestroyedObjects.Count; i++)
            {

                Destroy(GameObject.Find(NamesOfDestroyedObjects[i]));
            }

        }

    }

 */
}
