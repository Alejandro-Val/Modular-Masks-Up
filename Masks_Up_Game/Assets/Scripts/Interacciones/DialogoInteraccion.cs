using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoInteraccion : MonoBehaviour
{
    [SerializeField] private GameObject visualCue; //Boton Interactuar
    [SerializeField] private GameObject visualClick;
    private bool flag; //Jugador en rango
    public bool dialogueReadAgain = false;
    private bool dialogueRead = false;
    [SerializeField] private TextAsset inkJSON;

    public bool DialogueRead
    {
        get { return dialogueRead; }
    }


    private void Start()
    {
        visualCue.SetActive(false);
        visualClick.SetActive(false);
        flag = false;
    }

    private void Update()
    {
        if (dialogueRead == true)
        {
            return;
        }
        if (flag && !DialogoManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            visualClick.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                activarFuncion();
            }
        }
        else
        {
            visualCue.SetActive(false);
            visualClick.SetActive(false);
        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            flag = true;
        }
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            flag = false;
        }

    }

    public void activarFuncion()
    {
        visualCue.SetActive(false);
        visualClick.SetActive(false);
        flag = false;
        DialogoManager.GetInstance().EnterDialogueMode(inkJSON);
        if (dialogueReadAgain == false)
        {
            dialogueRead = true;
        }
        
    }



}
