using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    Rigidbody2D Rb;
    public int dir = 1;
    public bool check = false;
    public float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if(check)
     {
      timer -= Time.deltaTime;
      if(timer <= 0)
      {
       check = false;
       timer = 2;
      }
     }
    }

    void FixedUpdate()
    {
     Rb.velocity = new Vector2(-6 * dir, Rb.velocity.y);
    }
    public void Dirconfig()
    {
     dir = -dir;
    }
}
