using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameraFollow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;
    public int suavidade = 5;
    
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - alvo.position;
    }

    
    void Update()
    {
        Vector3 posFinal = alvo.position + offset;
        transform.position = Vector3.Lerp(transform.position, posFinal, suavidade * Time.deltaTime);
    }
}
 