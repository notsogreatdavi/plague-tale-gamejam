using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    public float speed;

    Rigidbody2D rigidbody1;

    public GameObject bulletPrefab;
    
    public float bulletSpeed;

    private float lastFire;

    public float fireDelay;
    public int dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Aqui n foi");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log("Aqui foi");
        float shootHor = Input.GetAxis("Fire1");
        if((shootHor != 0) && Time.time > lastFire + fireDelay)
        {
            Shoot(shootHor);
            lastFire = Time.time;
        }
        //Debug.Log("N foi");
        rigidbody1.velocity = new Vector3(horizontal * speed, vertical * speed, 0);
    }

    void Shoot(float x)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
        bullet.AddComponent<Rigidbody2D>().gravityScale = 0;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (dir < 0) ? Mathf.Floor(x) * bulletSpeed : Mathf.Ceil(x) * bulletSpeed,
            0,
            0
        );
    }

}
