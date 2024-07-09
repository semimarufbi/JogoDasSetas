using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    UIManager instance;
    #region singlenton
    private void Awake()
    {
        instance = this;
    }

    #endregion
    [SerializeField]
    public Image[] imagens;
    [SerializeField]
    public Sprite[] sprites;
    [SerializeField]
    TextMeshProUGUI textoDePontuacao,textoDoRelogio;
    void atualizarSetas(KeyCode[] setas)
    { 
        for(int i = 0; i <imagens.Length; i++)
        {
            if (i>= setas.Length)
            {
                Image[i].sprite = sprites[0];  
            }
        }
    }
                
    
    

}