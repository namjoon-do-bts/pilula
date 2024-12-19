using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class pilula : MonoBehaviour
{
    public float velocidade = 10f;
     public float focaPulo = 10f;

       public bool nochao = false;

       private Rigidbody2D _rigidbody2D;
       private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
     _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
     spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
     

    }
    void OnCollisionStay2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "chao")
      {
        nochao = true;
      }
    
    }

    void OnCollisionExite2D(Collision2D collision)
    
    {
        if(collision.gameObject.tag == "chao")
        {
            nochao = false;
        }

    }


    // Update is called once per frame
    void Update()
    {
        

    }
}




























