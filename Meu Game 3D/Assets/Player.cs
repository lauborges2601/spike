using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;


public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 10;
    public bool chao = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        Debug.Log("START");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            chao = true;
        }
        
        if (collision.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
        


    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        
        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            rb.AddForce(Vector3.up * + forcaPulo, ForceMode.Impulse);
           chao = false;
        }
        
        
        if (transform.position.y< -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }    
        Debug.Log("UPDATE"); 
    }
}
    //amo BTS meu utted é o Jimin. Sou army #BTSarmyForever Kim namjoon, Kim Seokjin, Min Yoongi, Jeon Hoseok, Park Jimin
    //Kim Taehyung, Jeon Jungkoo, BTS, BTS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
