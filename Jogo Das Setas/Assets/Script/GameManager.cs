using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pontos, teclaAtual;
    float relogio;
    KeyCode[] teclas;

    private void Start()
    {
        GerarSetas();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChecarTecla(DownArrow);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            ChecarTecla(UpArrow);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChecarTecla(RightArrow);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChecarTecla(LeftArrow);
        }
        ContagemRegressiva();
    }
    void ContagemRegressiva() 
    {
        relogio =- Time.deltaTime;
        AtualizarTextos(pontos, relogio);

        if (relogio<=0)
        {
            pontos -= teclas.Length;
            GerarSetas();
        }
    }
    void GerarSetas() 
    { 
     teclaAtual = 0;
        
    }
}
