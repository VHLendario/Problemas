using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int [] numero;

    void Start()
    {

        for (int i = 0; i < numero.Length; i ++)
        {
            Debug.Log(numero[i]);
        }
    }


    void Update()
    {
        
    }
}
