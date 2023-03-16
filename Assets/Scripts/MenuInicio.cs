using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicio : MonoBehaviour
{
    public void Jugar()
    {
        Debug.Log("COMIENZA JUEGO");
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
