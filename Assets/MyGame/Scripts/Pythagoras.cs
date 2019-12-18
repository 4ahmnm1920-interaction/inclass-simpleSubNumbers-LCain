using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{

    public int NumberInput1;
    public int NumberInput2;

    public float a;
    public float b;

    private void Start()
    {
        //int result = Square(NumberInput1,NumberInput2) + Square(NumberInput1,NumberInput2);
        //Debug.Log("Result Addition: " + result);
        Pythogaras(a, b);
    }

    void OnValidate()
    {
        //Square(NumberInput1,NumberInput2);
    }

     int Square(int Num1, int Num2)
    {
        //Debug.Log ("Result Square: " + Num1*Num2);
        return (Num1*Num2);
    }

    void Pythogaras(float a, float b)
    {
        float cSquare;
        cSquare = (a * a + b * b);
        Debug.Log("cSquare: " + cSquare);
        float c = (Mathf.Sqrt(cSquare));
        Debug.Log("c: " + (Mathf.Sqrt(cSquare)));
    }
}
