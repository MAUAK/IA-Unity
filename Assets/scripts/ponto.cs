using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ponto : MonoBehaviour
{
    //Criando uma vari�vel de material
    public Material cor;
    private void OnTriggerEnter(Collider other)
    {
        //Trocando o material pelo material que est� na vari�vevl
            GetComponent<Renderer>().material = cor;
      
    }
}
