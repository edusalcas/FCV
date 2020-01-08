using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBotonAnimacion : MonoBehaviour
{

    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Text textoObjeto;
    [SerializeField]
    private string texto;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoObjeto.text = texto;
            textoObjeto.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetBool("play", true);
                textoObjeto.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoObjeto.gameObject.SetActive(false);
        }
    }
}
