using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    void Start()
    {
        Seu_Triangulo ();
    }

    void Update()
    {
        
    }

    void Seu_Triangulo ()
    {
        //para quando for equilátero
        if (x == y && x == z)
        {
            Debug.Log("Seu triângulo é equilátero!");
        }

        //para quando for isóceles
        if (x == y && x != z)
        {
            Debug.Log("Seu triângulo é isóceles!");
        }
        if (y == z && y != x)
        {
            Debug.Log("Seu triângulo é isóceles!");
        }
        if (z == x && z != y)
        {
            Debug.Log("Seu triângulo é isóceles!");
        }

        //para quando for escaleno
        if (x != y && x != z && y != z)
        {
            Debug.Log("Seu triângulo é escaleno!");
        }
      
    }
}
