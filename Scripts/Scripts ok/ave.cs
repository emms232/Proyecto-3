using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ave : MonoBehaviour
{
    public int targetFrameRate = 30;

    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Light"))
        {
            other.GetComponent<BoxCollider>().enabled = false;
        }

    }

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
    }
}
