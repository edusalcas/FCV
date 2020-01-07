using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationPuerta : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Piedra"))
        {
            animator.SetBool("play", true);
        }
    }
}
