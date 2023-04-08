using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffstype : MonoBehaviour
{
    Rigidbody2D rb;
    public bool redbuff;
    public bool greenbuff;
    public bool bluebuff;
    // Start is called before the first frame update
    void Start()
    {
     rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate()
    {
     rb.velocity = new Vector2(-5, rb.velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.CompareTag("Player"))
     {
      if(redbuff)
      {
        //vai adicionar mais 1 de dano por 10 segundos;
        Destroy(this.gameObject);
      }
       if(greenbuff)
      {
        //vai recuperar a vida do player por completo;
       Destroy(this.gameObject);
      }
       if(bluebuff)
      {
       //vai aumentar a velocidade do player por 10 segundos;
       Destroy(this.gameObject);
      }
     }
    }
}
