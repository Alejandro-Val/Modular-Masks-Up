using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoMovement : MonoBehaviour
{
    [SerializeField] float amplitude = 10f; // Amplitud del movimiento oscilatorio
    [SerializeField] float frequency = 1f; // Frecuencia del movimiento oscilatorio

    Vector2 initialPosition; // Posición inicial del objeto

    void Start()
    {
        initialPosition = transform.position; // Guardamos la posición inicial del objeto
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency) * amplitude; // Calculamos el offset en función del tiempo y la frecuencia

        transform.position = initialPosition + Vector2.up * offset; // Movemos el objeto en función del offset generado
    }
}
