using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaiorNumeroManager : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    void Start()
    {
        Maior ();
    }

    void Update()
    {
        
    }

    void Maior ()
    {
        if (x > y && x > z)
        {
            Debug.Log(x + " é o maior número!");
        }
        
        if (y > x && y > z)
        {
            Debug.Log(y + " é o maior número!");
        }

        if (z > y && z > x)
        {
            Debug.Log(z + " é o maior número!");
        }
    }
}
