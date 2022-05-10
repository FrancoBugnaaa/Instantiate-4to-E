using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCLoneAmount;
    public GameObject objectToClone;
    int cloneAmount;

    public void MultipleInstantiate()
    {
        if(txtUserCLoneAmount.text != ""){
            cloneAmount = int.Parse(txtUserCLoneAmount.text);
        }
        int counter = 0;
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
