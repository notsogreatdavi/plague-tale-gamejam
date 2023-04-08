using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //Pos spawn
    public GameObject enemyprefab;
    public Transform[] spawnpoint;
    int lastpos = 6;
    List<int> rand2 = new List<int>();
    int rand;
    private Transform pos;
    //end
    int enemywave = 5;
    int[] Enemycount;
    //Inicio e fim de round
    bool roundstart;
    bool roundend;
    // end
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
        if(enemywave != 5)
        {
          for(int i = 0; i < enemywave; i++)
          {
            rand = Random.Range(0, 5);
            while(rand2.Contains(rand))
            {
            rand = Random.Range(0, 5);
            }
            Debug.Log(rand2);
            pos = spawnpoint[rand];
            Instantiate(enemyprefab, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
            rand2.Add(rand);
          }
        } else
        {
         for(int i = 0; i < enemywave; i++)
         {
          pos = spawnpoint[i];
          Instantiate(enemyprefab, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
         }
        }
      roundstart = false;
     }
    }
}
