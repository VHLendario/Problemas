using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointClicker : MonoBehaviour
{
    public int recursos_;
    public int recursos_por_click;
    public Text texto;

    void Start()
    {
        recursos_ = 0;
        recursos_por_click = 1;
    }

    void Update()
    {
        Recursos ();
    }

    public void Click ()
    {
        recursos_ = recursos_ + recursos_por_click;
    }

    public void ButtonUpgrade01 ()
    {
        if (recursos_ >= 30)
        {
            recursos_ = recursos_ - 30;
            recursos_por_click = recursos_por_click + 1;
        }
    }

    public void ButtonUpgrade02 ()
    {
        if (recursos_ >= 100)
        {
            recursos_ = recursos_ - 100;
            recursos_por_click = recursos_por_click + 3;
        }
    }

    public void Recursos ()
    {
        texto.text = recursos_.ToString();
    }
}
