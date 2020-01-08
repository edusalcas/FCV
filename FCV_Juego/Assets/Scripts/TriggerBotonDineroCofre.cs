using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBotonDineroCofre : MonoBehaviour
{
    [SerializeField]
    private GameObject coins;
    [SerializeField]
    private Text textoObjeto;
    [SerializeField]
    private string texto;
    [SerializeField]
    private charController player;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoObjeto.text = texto;
            textoObjeto.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                coins.SetActive(false);
                textoObjeto.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                player.PickCoins(10);
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
