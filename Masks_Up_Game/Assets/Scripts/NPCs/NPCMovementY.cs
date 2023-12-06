using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovementY : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float speed = 0.6f;
    public float waitTime = 1.0f;

    private Vector2 targetPosition;
    private bool readyToMove = false;
    private bool reachedEndPosition = false;
    private bool isMoving = false;
    private bool isBeingTouched = false;
    private Animator animator;
    private Rigidbody2D rigidBody;

    void Start()
    {
        transform.position = startPosition;
        targetPosition = endPosition;
        readyToMove = true;
        animator = GetComponent<Animator>();
        animator.Play("idle");
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (readyToMove && !isBeingTouched)
        {
            if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
            {
                if (reachedEndPosition)
                {
                    reachedEndPosition = false;
                    StartCoroutine(WaitAtEnd());
                    animator.Play("idle");
                }
                else
                {
                    reachedEndPosition = true;
                    StartCoroutine(WaitAtStart());
                    animator.Play("idle");
                }
            }

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (transform.position.y > targetPosition.y)
            {
                if (transform.position.x != endPosition.x || transform.position.y != endPosition.y)
                {
                    animator.Play("MovimientoAbajo");
                    isMoving = true;
                }
            }
            else if (transform.position.y < targetPosition.y)
            {
                if (transform.position.x != startPosition.x || transform.position.y != startPosition.y)
                {
                    animator.Play("MovimientoArriba");
                    isMoving = true;
                }
            }
        }
        else
        {
            animator.Play("idle");
            isMoving = false;
        }
    }

    IEnumerator WaitAtStart()
    {
        readyToMove = false;
        rigidBody.bodyType = RigidbodyType2D.Static;
        animator.Play("idle");
        yield return new WaitForSeconds(waitTime);
        targetPosition = startPosition;
        readyToMove = true;
        rigidBody.bodyType = RigidbodyType2D.Dynamic;
    }

    IEnumerator WaitAtEnd()
    {
        readyToMove = false;
        rigidBody.bodyType = RigidbodyType2D.Static;
        animator.Play("idle");
        yield return new WaitForSeconds(waitTime);
        targetPosition = endPosition;
        readyToMove = true;
        rigidBody.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rigidBody.bodyType = RigidbodyType2D.Static;
            readyToMove = false;
            isBeingTouched = true;
            if (!isMoving)
            {
                animator.Play("idle");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rigidBody.bodyType = RigidbodyType2D.Dynamic;
            readyToMove = true;
            isBeingTouched = false;
        }
    }
}
