using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    Vector2 initialPosition; // Almacenamos la posición inicial del objeto

    [SerializeField] float movementQuantity;

    void Start()
    {
        initialPosition = this.GetComponent<RectTransform>().position; // Guardamos la posición inicial del objeto
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); // Obtenemos la cantidad de movimiento del mouse en X
        float mouseY = Input.GetAxis("Mouse Y"); // Obtenemos la cantidad de movimiento del mouse en Y

        Vector2 movement = new Vector2(mouseX, mouseY) * movementQuantity; // Calculamos la cantidad de movimiento basándonos en la sensibilidad definida

        this.GetComponent<RectTransform>().position = initialPosition + movement; // Movemos el objeto sumando la posición inicial y la cantidad de movimiento
    }
}
