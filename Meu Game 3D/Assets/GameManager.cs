using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMeneger : MonoBehaviour
{
    public int moedas;
    public TMP_Text hud, msgVitoria; 
    void Start()
    {
        moedas = FindObjectsOfType<moedas>().Length;
        
    }

    public void AtualizarHud()
    {
        hud.text = $"Moedas restantes: {moedas}";
    }

    public void SubtrairMoedas(int valor)
    {
        moedas -= valor;
        AtualizarHud();
        if (moedas <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "Parabéns";
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
