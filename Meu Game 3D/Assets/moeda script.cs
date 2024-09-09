using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedas : MonoBehaviour
{
    public int velocidadeGiro = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
             Destroy(gameObject);
             FindObjectOfType<GameMeneger>().SubtrairMoedas(valor:1);
        }

}


    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
        
        
        
        
    }
}
