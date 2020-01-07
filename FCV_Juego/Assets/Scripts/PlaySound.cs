using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioS;
    [SerializeField]
    private AudioClip audioC;

    public void Play()
    {
        audioS.PlayOneShot(audioC);
    }
}
