using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTopDown : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // velocidad de movimiento
    public Animator animator; // el componente Animator del personaje
    private Vector2 direction; // la dirección actual del personaje
    private Rigidbody2D rb2D; // el componente Rigidbody2D del personaje
    private bool isMoving; // indica si el personaje se está moviendo o no
    public AudioSource audioSource; // el componente AudioSource que reproducirá los sonidos de pasos
    public AudioClip audioClip; // el AudioClip de los sonidos de pasos
    public float tiempoEntrePasos = 0.5f; // tiempo entre cada sonido de pasos (en segundos)
    private float tiempoPasado = 0f; // tiempo que ha pasado desde el último sonido de pasos

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (DialogoManager.GetInstance().dialogueIsPlaying)
        {
            animator.SetBool("isMoving", false);
            return;
        }
        animator.enabled = true;
        // obtener entrada de movimiento horizontal y vertical
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // si el personaje se está moviendo en alguna dirección
        if (moveHorizontal != 0f || moveVertical != 0f)
        {
            // establecer la dirección del personaje
            direction = new Vector2(moveHorizontal, moveVertical).normalized;

            // mover al personaje
            rb2D.MovePosition(rb2D.position + direction * velocidadMovimiento * Time.fixedDeltaTime);

            // reproducir la animación de movimiento correspondiente a la dirección
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);

            // indicar que el personaje se está moviendo
            isMoving = true;

            // actualizar el temporizador de los sonidos de pasos
            tiempoPasado += Time.deltaTime;
            if (tiempoPasado >= tiempoEntrePasos)
            {
                // reproducir el sonido de pasos
                audioSource.PlayOneShot(audioClip);

                // reiniciar el temporizador de los sonidos de pasos
                tiempoPasado = 0f;
            }
        }
        else
        {
            // detener la animación de movimiento y reproducir la animación de idle correspondiente a la dirección
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);

            // indicar que el personaje no se está moviendo
            isMoving = false;
        }

        // indicar al animator si el personaje se está moviendo o no
        animator.SetBool("isMoving", isMoving);
    }
}
