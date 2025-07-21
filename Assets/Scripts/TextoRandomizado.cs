using System;
using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
   public string novoTexto;
   public TextMeshProUGUI UITexto;
   
   public int numero;

   private void Start()
   {
       UITexto.text = novoTexto + " " + numero;
   }

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0)
        {
            numero--;
            UITexto.text = novoTexto + " " + numero;
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            numero++;
            UITexto.text = novoTexto + " " + numero;
        }
    }

    public void SomaUm()
    {
        numero++;
        UITexto.text = novoTexto + " " + numero;
    }
}