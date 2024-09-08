using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joken : MonoBehaviour
{
    public InputField name_01;
    public InputField name_02;
    public InputField escolha_01;
    public InputField escolha_02;
    public InputField number_01;
    public InputField number_02;
    public Text vencedor;

    string mao_jogador_01;
    string mao_jogador_02;
    int numero_jogador_01;
    int numero_jogador_02;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_Play ()
    {
        Regras ();
    }

    void Regras ()
    {
        //variaveis para funcionar
        mao_jogador_01 = escolha_01.text;
        mao_jogador_02 = escolha_02.text;
        numero_jogador_01 = int.Parse(number_01.text);
        numero_jogador_02 = int.Parse(number_02.text);
        int soma = numero_jogador_01 + numero_jogador_02;
        int resultado = soma % 2;
        //jogo em si
        if ((resultado == 0 && mao_jogador_01 == "par") || (resultado == 0 && mao_jogador_01 == "Par"))
        {
            vencedor.text = "Parabéns " + name_01.text + ", você ganhou pois " + soma + " é par.";
        }
        if ((resultado == 0 && mao_jogador_02 == "par") || (resultado == 0 && mao_jogador_02 == "Par"))
        {
            vencedor.text = "Parabéns " + name_02.text + ", você ganhou pois " + soma + " é par.";
        }
        if ((resultado == 1 && mao_jogador_01 == "impar") || (resultado == 1 && mao_jogador_01 == "Impar"))
        {
            vencedor.text = "Parabéns " + name_01.text + ", você ganhou pois " + soma + " é impar.";
        }
        if ((resultado == 1 && mao_jogador_02 == "impar") || (resultado == 1 && mao_jogador_02 == "Impar"))
        {
            vencedor.text = "Parabéns " + name_02.text + ", você ganhou pois " + soma + " é impar.";
        }
    }
}
