using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ponto : MonoBehaviour
{
    //Criando uma variável de material
    public Material cor;
    private void OnTriggerEnter(Collider other)
    {
        //Trocando o material pelo material que está na variávevl
            GetComponent<Renderer>().material = cor;
      
    }
}
