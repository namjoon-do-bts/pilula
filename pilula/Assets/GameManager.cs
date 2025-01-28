using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Monedas;
    // Start is called before the first frame update
    void Start()
    {
        Monedas = FindObjectsOfType<moeda>().Length;
    }
    public void subtrairmoedas(int valor){
        Monedas -= valor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
