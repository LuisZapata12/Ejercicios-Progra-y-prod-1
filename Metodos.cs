using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Metodos : MonoBehaviour
{
    
    public bool Resta;
    public bool Sumatoria;
    public int a;
    public int b;
    private int c;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Resta)
        {
            resta();
        }
        if (Sumatoria)
        {
            resta();
        }
    }
    public void Suma()
    {
        Console.WriteLine("La suma es" + (a + b));
    }
    public void resta()
    {
        Console.WriteLine("La resta es" + (a - b));
    }
}
