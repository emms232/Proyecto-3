using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLight : MonoBehaviour
{

    [SerializeField] public Animator luz;
    [SerializeField] private string light = "Light";

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            luz.Play(light, 0, 0.0f);


        }
        
    }

    

  
}
