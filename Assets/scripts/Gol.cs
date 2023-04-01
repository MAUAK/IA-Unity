using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    //Criando uma variável de audio
    public AudioSource galvão;
    //Criando uma variável de jogo ganho
    public GameObject Gamewin;

    private void OnTriggerEnter(Collider other)
    {
        //Comparando se quem colidiu tem a tag player
        if(other.CompareTag("Player"))
        {
            //Tocando o áudio
            galvão.Play();
            //Acionando a tela de jogo ganho
            Gamewin.SetActive(true);
            //Destruindo o player
            Destroy(other);
        }
    }
}
