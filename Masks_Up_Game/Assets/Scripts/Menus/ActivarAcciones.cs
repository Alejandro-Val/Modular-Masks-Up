using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAcciones : MonoBehaviour
{
    public ImageTextScript imageTextScript;

    public void OnButtonClick()
    {
        imageTextScript.ShowImageAndText();
    }
}
