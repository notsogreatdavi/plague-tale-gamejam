using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawner : MonoBehaviour
{
    public float timertospawn = 10;
    public GameObject[] buffs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     timertospawn -= Time.deltaTime;
     if(timertospawn <= 0)
     {
      Instantiate(buffs[Random.Range(0, buffs.Length)], new Vector2(10.68f, Random.Range(-3,3)), Quaternion.identity);
      timertospawn = Random.Range(7, 12);
     }  
    }
}
