using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianguloBinário : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        meuloop ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void meuloop ()
    {
        int numero_binario = 0;
        string resultado = "";
        for (int i = 0; i < x; i ++ )
        {
            for (int j = 0; j < i + 1; j++)
            {
                resultado += numero_binario.ToString();

                if (numero_binario == 0)
                {
                    numero_binario = 1;
                }
                else
                {
                    numero_binario = 0;
                }
            }
            Debug.Log(resultado);
        }
    }
}
