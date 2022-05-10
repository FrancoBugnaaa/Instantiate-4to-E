using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{
    public Text txtUsername;

    public void ShowGreetings()
    {
        Debug.Log("Hola " + txtUsername.text);
    }

    public void ShowDouble()
    {
        if(txtUsername.text != "")
        {
            Debug.Log(int.Parse(txtUsername.text) * 2);
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }
    }
   
}
