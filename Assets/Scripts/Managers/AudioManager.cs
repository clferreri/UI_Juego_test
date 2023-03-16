using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource sonido, musica;

    public static AudioManager Instancia { get; private set; }

    private bool seEstaReproduciendoMusica = false;

    private void Awake()
    {
        if(Instancia != null && Instancia != this) 
        {
            Destroy(this);
        }
        else
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
    }


    public void EjecutarSonido(AudioClip clip)
    {
        this.sonido.PlayOneShot(clip);
    }

    public void EjecutarMusica(AudioClip clip)
    {
        this.musica.PlayOneShot(clip);
    }

    public bool SeEstaReproduciendoMusica()
    {
        return this.seEstaReproduciendoMusica;
    }

    public void CambiarEstadoMusica()
    {
        this.musica.mute = !this.seEstaReproduciendoMusica;
    }
}
