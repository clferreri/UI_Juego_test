using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioClip musica;
    void Start()
    {
        AudioManager.Instancia.EjecutarMusica(musica);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
