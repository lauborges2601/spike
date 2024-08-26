using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameraFollow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - alvo.position;
    }

    
    void Update()
    {
        transform.position = alvo.position + offset;
    }
}
