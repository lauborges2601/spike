using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class moedas : MonoBehaviour
{
    public int velocidadeGiro = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            FindObjectOfType<GameMeneger>().SubtrairMoedas (Valor:1);
                            
        }
        
            
    }
    void Update()
    {
       transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);   
        
        
    }
}


   
