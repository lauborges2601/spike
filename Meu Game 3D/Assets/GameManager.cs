using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMeneger : MonoBehaviour
{
    public TextMeshProUGUI HUD, MsgVitoria;
    public int restantes;

    void Start()
    {
        restantes = FindObjectsOfType<moedas>().Length;

        HUD.text = $"moedas Restantes: {restantes}";
    }
    

    public void SubtrairMoedas (int Valor)
    {
        restantes -= Valor;
        HUD.text = $"moedas Restantes: {restantes}"; 

        if (restantes <= 0)
        {
            //ganhou o jogo
            MsgVitoria.text = "Congratulations!";
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
