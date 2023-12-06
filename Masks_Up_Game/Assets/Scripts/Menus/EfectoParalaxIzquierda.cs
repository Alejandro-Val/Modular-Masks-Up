using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectoParalaxIzquierda : MonoBehaviour
{
    public float speedParalax;
    public RawImage fondo;

    private float finalSpeed;

    // Update is called once per frame
    void Update()
    {
        finalSpeed = (speedParalax * Time.deltaTime);

        fondo.uvRect = new Rect(fondo.uvRect.x - finalSpeed, 0f, 1f, 1f); // Cambiamos el signo '-' a '-' para desplazarse hacia la derecha.
    }
}
