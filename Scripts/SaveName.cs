using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SaveName : MonoBehaviour
{

    public InputField nameField;

    public Button submit;

    public void CallRegister()
    {
        StartCoroutine(GetText());
    }

    

    IEnumerator GetText()
    {

        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        

        UnityWebRequest www = UnityWebRequest.Get("http://localhost/sqlconnect/register.php");
        yield return www.SendWebRequest();

        /*
        if (www.text == "0")
        {
            UnityEngine.
        }
        */
    }

    public void VerifyInputs()
    {
        //submit.interactable;
    }
}
