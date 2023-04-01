using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    //Criando varável do tipo array para os pontos de destino
    public Transform[] waypoints;
    //Criando uma variável de velocidade
    public float speed = 0.5f;
    //Criando uma variável de ponto atual
    private int currentWaypoint = 0;
    //public Material[] cor;
    

    private void Update()
    {
        //Verificando se o valor dav variável ponto atual é menor que o tamanho do array dos pontos de destino
        if(currentWaypoint < waypoints.Length)
        {
            //movimento o objeto para ir até os pontos de destino um por um com a velocidade do speed
            transform.position = Vector3.MoveTowards(transform.position,
                waypoints[currentWaypoint].position, speed * Time.deltaTime);
            //Verificando se a posição do objeto é a mesma que a posição de um ponto de destino
            if(transform.position == waypoints[currentWaypoint].position)
            {
                //Somando mais um na variável de ponto atual
                currentWaypoint++;
                //GetComponent<Renderer>().material = cor[currentWaypoint];
            }
        }
    }
     
}
