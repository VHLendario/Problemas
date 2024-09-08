using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContaManager : MonoBehaviour
{
    public int x;
    public int y;
    int z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_Jogar ()
    {
        z = x + y;
        Debug.Log(z);
    }
}
