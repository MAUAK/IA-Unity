using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerMoviment : MonoBehaviour
{
    //Criando vari�veis do player
    private Rigidbody rb;
    private Vector2 movimento;
    public float speed = 2f;
   
    // Start is called before the first frame update
    void Start()
    {
        //Pegando o rigidbody do player
        rb = GetComponent<Rigidbody>();
    }

    //Criando m�todo de movimento
    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        //Adicionando for�a ao rigidybody para o player se movimentar
        rb.AddForce(new Vector3(movimento.x, 0,movimento.y) * speed * Time.fixedDeltaTime *300);
        
        
    }

    //Criando m�todo para player pular
    public void SetJump(InputAction.CallbackContext value)
    {
        rb.AddForce(Vector3.up * 100);
    }

    //Criando m�todo para carregar cena
    public void carregarcena()
    {
            SceneManager.LoadScene(0);
    }
}
