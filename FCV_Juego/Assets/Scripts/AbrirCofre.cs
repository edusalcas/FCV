using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCofre : MonoBehaviour
{
    [SerializeField]
    private GameObject trigger;

    public void activarTrigger()
    {
        trigger.SetActive(true);
    }
}
