using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomEffect : MonoBehaviour
{
    public float zoomSpeed = 0.5f; // Velocidad del zoom
    public float maxZoom = 2f; // Máximo zoom permitido
    public float minZoom = 0.5f; // Mínimo zoom permitido

    private bool zoomingIn = true;
    private float currentZoom = 1.0f;

    void Update()
    {
        // Cambia la escala gradualmente
        if (zoomingIn)
        {
            currentZoom += zoomSpeed * Time.deltaTime;
            if (currentZoom >= maxZoom)
                zoomingIn = false;
        }
        else
        {
            currentZoom -= zoomSpeed * Time.deltaTime;
            if (currentZoom <= minZoom)
                zoomingIn = true;
        }

        // Aplica la escala al fondo
        transform.localScale = new Vector3(currentZoom, currentZoom, 1f);
    }
}
