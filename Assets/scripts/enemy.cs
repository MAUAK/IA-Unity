using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //Vector3 goal = new Vector3(5,0,4);

    //Criando v�riavel de velocidade
    public float speed = 2.0f;
    //Criando vari�vel de precis�o
    public float accuracy = 0.01f;
    //Criando vari�vel do tipo transform para o lugar que ele dever� ir
    public Transform goal;
    //Criando vari�vel para aparecer tela de fim de jogo
    public GameObject Gameover;

    // Update � chamado uma vez por frame
    void Update()
    {
        //Informando para onde o objeto deve olhar
        this.transform.LookAt(goal.position);
        //Criando um vector 3 de dire��o, com o valor da posi��o do objetivo menos a do objeto
        Vector3 direction = goal.position - this.transform.position;
        //Desenhar uma linha dessa dist�ncia
        Debug.DrawRay(this.transform.position, direction, Color.red);
        //Verificando se o valor da dire��o � menor que o vlaor da precis�o
        if(direction.magnitude > accuracy)
        {
            //movimento o objeto para o destino com a velocidade speed
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        
    }

    //Assim que algu�m encostar no objeto aciona um gatilho
    private void OnTriggerEnter(Collider other)
    {
        //Verificando se quem colidiu tem a tag player
        if (other.CompareTag("Player"))
        {
            //Ativa a tela de fim de jogo
            Gameover.SetActive(true);
            //destroi o player
            Destroy(other);
        }
    }
}
