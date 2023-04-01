using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    //Criando var�vel do tipo array para os pontos de destino
    public Transform[] waypoints;
    //Criando uma vari�vel de velocidade
    public float speed = 0.5f;
    //Criando uma vari�vel de ponto atual
    private int currentWaypoint = 0;
    //public Material[] cor;
    

    private void Update()
    {
        //Verificando se o valor dav vari�vel ponto atual � menor que o tamanho do array dos pontos de destino
        if(currentWaypoint < waypoints.Length)
        {
            //movimento o objeto para ir at� os pontos de destino um por um com a velocidade do speed
            transform.position = Vector3.MoveTowards(transform.position,
                waypoints[currentWaypoint].position, speed * Time.deltaTime);
            //Verificando se a posi��o do objeto � a mesma que a posi��o de um ponto de destino
            if(transform.position == waypoints[currentWaypoint].position)
            {
                //Somando mais um na vari�vel de ponto atual
                currentWaypoint++;
                //GetComponent<Renderer>().material = cor[currentWaypoint];
            }
        }
    }
     
}
