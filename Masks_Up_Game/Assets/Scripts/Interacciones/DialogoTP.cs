using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTP : MonoBehaviour
{
    [SerializeField] private GameObject visualClick;
    private bool flag; //Jugador en rango
    public bool dialogueReadAgain = false;
    private bool dialogueRead = false;
    [SerializeField] private TextAsset inkJSON;
    public TpDiferenteCamara tpDiferenteCamara;
    private DialogueVariables dialogueVariables;
    bool valor = false;
    

    public bool DialogueRead
    {
        get { return dialogueRead; }
    }


    private void Start()
    {
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
            visualClick.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                activarFuncion();
            }
        }
        else
        {
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
        valor = ((Ink.Runtime.BoolValue) DialogoManager.GetInstance().GetVariableState("flag")).value;
        if (valor != null && !valor)
        {
            DialogoManager.GetInstance().EnterDialogueMode(inkJSON);
            visualClick.SetActive(false);
            flag = false;
            if (dialogueReadAgain == false)
            {
                dialogueRead = true;
            }
        }
        else
        {
            tpDiferenteCamara.tp();
        }

        
        
    }



}
