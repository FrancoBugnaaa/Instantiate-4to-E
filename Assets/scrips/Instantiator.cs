using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCLoneAmount;
    public GameObject objectToClone;
    int cloneAmount;
    GameObject clon;

    public void MultipleInstantiate()
    {
        if (txtUserCLoneAmount.text != "")
        {
            cloneAmount = int.Parse(txtUserCLoneAmount.text);
        }
        for (int i = 0; i < cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);
        }
    }
}
