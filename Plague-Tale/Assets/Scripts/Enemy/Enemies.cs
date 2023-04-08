using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    
    LevelSystem teste;
    [SerializeField] float health, maxHealth = 3f;

    Rigidbody2D Rb;
    public int dir = 1;
    public bool check = false;
    public float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        teste = GameObject.FindGameObjectsWithTag("Player").getcomponent<LevelSystem>();
        Rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            teste.GainExperienceFlatRate(70);
            Destroy(gameObject);
        }
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
