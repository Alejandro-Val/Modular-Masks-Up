using UnityEngine;

public class KariSeguimientoSinHablar : MonoBehaviour
{
    public GameObject kari;
    public Transform jugador;
    public float distanciaMinima = 1.0f;
    public float distanciaMaxima = 5.0f; // Distancia máxima para cambiar el isTrigger
    public float velocidad = 3.0f;
    public float rayLength = 1.0f;
    public Animator animator;

    private bool isFollowing = false;
    private Rigidbody2D rb;
    private Collider2D collider2D;
    private bool isTriggerInitially;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();
        isTriggerInitially = collider2D.isTrigger;
    }

    private void Update()
    {
            kari.layer = LayerMask.NameToLayer("Personaje");
            Vector3 direccion = jugador.position - transform.position;
            float distanciaAlJugador = direccion.magnitude;
            rb.isKinematic = false;

            // Cambiar isTrigger si el compañero se aleja demasiado del jugador.
            if (distanciaAlJugador >= distanciaMaxima)
            {
                collider2D.isTrigger = true;
            }
            else if (distanciaAlJugador <= distanciaMinima)
            {
                collider2D.isTrigger = false;
            }

            if (distanciaAlJugador <= distanciaMinima)
            {
                if (!isFollowing)
                {
                    isFollowing = true;
                    if (animator != null)
                    {
                        animator.SetBool("IsMoving", false);
                    }
                }
            }
            else
            {   
                isFollowing = false;
                direccion.Normalize();
                RaycastHit2D hit = Physics2D.Raycast(transform.position, direccion, rayLength);

                if (hit.collider != null)
                {
                    direccion = Quaternion.AngleAxis(45, Vector3.back) * direccion;
                    direccion.Normalize();
                }

                Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;

                if (Mathf.Abs(direccion.x) > Mathf.Abs(direccion.y))
                {
                    desplazamiento.y = 0.0f;
                }
                else
                {
                    desplazamiento.x = 0.0f;
                }

                transform.position += desplazamiento;

                if (animator != null)
                {
                    float moveHorizontal = direccion.x;
                    float moveVertical = direccion.y;

                    if (direccion.sqrMagnitude > 0)
                    {
                        animator.SetBool("IsMoving", true);

                        if (Mathf.Abs(moveHorizontal) > Mathf.Abs(moveVertical))
                        {
                            animator.SetFloat("Horizontal", moveHorizontal);
                            animator.SetFloat("Vertical", 0);
                        }
                        else
                        {
                            animator.SetFloat("Horizontal", 0);
                            animator.SetFloat("Vertical", moveVertical);
                        }
                    }
                    else
                    {
                        animator.SetBool("IsMoving", false);
                    }
                }
            }
    }
}
