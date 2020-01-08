using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationPiedra : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject textoBoton;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoBoton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                animator.SetBool("play", true);
                textoBoton.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            textoBoton.SetActive(false);
        }
    }
}
