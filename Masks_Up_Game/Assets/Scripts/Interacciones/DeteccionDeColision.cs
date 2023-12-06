using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColision : MonoBehaviour
{
    public GameObject botonInteractivoPuerta; //Boton Interactuar
    public bool flag;

    private void Start()
    {
        botonInteractivoPuerta.gameObject.SetActive(false);
        flag = false;
    }

    private void Update()
    {

        if (botonInteractivoPuerta.activeInHierarchy == true & Input.GetKeyDown(KeyCode.E))
        {
            activarFuncion();
        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        botonInteractivoPuerta.gameObject.SetActive(true);
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        botonInteractivoPuerta.gameObject.SetActive(false);
        flag = false;

    }

    public void activarFuncion()
    {
        flag = true;
    }
}
