using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
        Destroy (gameObject);}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
