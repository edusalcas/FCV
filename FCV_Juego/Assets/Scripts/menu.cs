using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    /*[SerializeField]
    GameObject panelAyuda;*/

    public void Jugar(int i)
    {
        SceneManager.LoadScene(i);
    }

    /*public void Ayuda()
    {
        panelAyuda.SetActive(true);
    }*/

    public void Salir()
    {
        Application.Quit();
    }

    /*public void SalirAyuda()
    {
        panelAyuda.SetActive(false);
    }*/
}
