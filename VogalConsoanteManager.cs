using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VogalConsoanteManager : MonoBehaviour
{
    public string letra;
    void Start()
    {
        VogalOuConsoante();
    }
    void Update()
    {
        
    }

    void VogalOuConsoante ()
    {
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
        {
            Debug.Log(letra + " é uma vogal!");
        }
        else {
            Debug.Log(letra + " é uma consoante!");
        }
    }
}
