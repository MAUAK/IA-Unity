using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    //Criando uma vari�vel de audio
    public AudioSource galv�o;
    //Criando uma vari�vel de jogo ganho
    public GameObject Gamewin;

    private void OnTriggerEnter(Collider other)
    {
        //Comparando se quem colidiu tem a tag player
        if(other.CompareTag("Player"))
        {
            //Tocando o �udio
            galv�o.Play();
            //Acionando a tela de jogo ganho
            Gamewin.SetActive(true);
            //Destruindo o player
            Destroy(other);
        }
    }
}
