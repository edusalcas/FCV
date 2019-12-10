using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    [SerializeField]
    GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        // TODO
        obj.SetActive(false);
    }
}
