using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParOuImpar : MonoBehaviour
{
    public string name_01;
    public string name_02;
    public string mão_jogador01;
    public string mão_jogador02;
    public int numero_01;
    public int numero_02;
    
    void Start()
    {
        Joken ();
    }

    void Update()
    {
        
    }

    void Joken ()
    {
      int soma = numero_01 + numero_02;
      int resultado = soma % 2;
      if ((resultado == 0 && mão_jogador01 == "par") || resultado == 0 && mão_jogador01 == "Par")
      {
        Debug.Log("Parabéns! " + name_01 + " venceu, " + " pois " + soma + " é par.");
      }
      if ((resultado == 0 && mão_jogador02 == "par") || resultado == 0 && mão_jogador02 == "Par")
      {
        Debug.Log("Parabéns! " + name_02 + " venceu, " + " pois " + soma + " é par.");
      }
      if ((resultado == 1 && mão_jogador01 == "impar") || resultado == 1 && mão_jogador02 == "Impar")
      {
        Debug.Log("Parabéns! " + name_01 + " venceu, " + " pois " + soma + " é impar.");
      }
      if ((resultado == 1 && mão_jogador02 == "impar") || resultado == 1 && mão_jogador02 == "Impar")
      {
        Debug.Log("Parabéns! " + name_02 + " venceu, " + " pois " + soma + " é impar.");
      }
    }
}
