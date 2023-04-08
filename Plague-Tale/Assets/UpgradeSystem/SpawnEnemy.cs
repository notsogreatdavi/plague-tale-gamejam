using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyprefab;
    public Transform[] spawnpoint;
    Transform lastpos;
    private Transform pos;
    int enemyround = 3;
    bool roundstart;
    bool roundend;
    void Start()
    {
     roundstart = true;
    }

    
    void Update()
    {
      StartRound();
    }
    void StartRound()
    {
     if(roundstart)
     {
      for(int i = 0; i < enemyround; i++)
      {
        pos = spawnpoint[i];
        Instantiate(enemyprefab, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
      } 
      roundstart = false;
     }
    }
}
