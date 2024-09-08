using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopManager : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        int soma = 0;
        for (int i = 0; i < x + 1; i++)
        {
            soma += i;
        }
        Debug.Log(soma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
