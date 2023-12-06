using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJoystick : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public Animator animator;
    private Rigidbody2D rb2D;
    private bool isMoving;
    public Joystick joystick;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public float tiempoEntrePasos = 0.5f;
    private float tiempoPasado = 0f;

    void Start()
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

        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical;
        Vector2 direction = new Vector2(moveX, moveY).normalized;

        if (direction.magnitude > 0.1f)
        {
            rb2D.MovePosition(rb2D.position + direction * velocidadMovimiento * Time.fixedDeltaTime);

            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);

            isMoving = true;

            tiempoPasado += Time.deltaTime;
            if (tiempoPasado >= tiempoEntrePasos)
            {
                audioSource.PlayOneShot(audioClip);
                tiempoPasado = 0f;
            }
        }
        else
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);

            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);
    }
}
