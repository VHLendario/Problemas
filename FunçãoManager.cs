using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunçãoManager : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    bool truf = false;

    void Start()
    {
        Função ();
        Debug.Log(truf);
    }

    void Update()
    {
        
    }
    
    void Função()
    {
        float conta = (x + y) * z;
        if (conta > 1000)
        {
            truf = true;
        }
        else {
           truf = false;
        }
    }
}
