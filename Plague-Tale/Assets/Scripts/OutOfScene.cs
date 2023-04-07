using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScene : MonoBehaviour
{
    public Transform point;
    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
    RaycastHit2D Hit = Physics2D.Raycast(point.position, new Vector2(0, -5), 10, mask);
     if(Hit && Hit.transform.GetComponent<Enemies>().check == false)
     {
      Hit.transform.GetComponent<Enemies>().Dirconfig();
      Hit.transform.GetComponent<Enemies>().check = true;
     }
    }
    void OnDrawGizmos()
    {
     Gizmos.color = Color.red;
     Gizmos.DrawLine(point.position, new Vector2(point.position.x, -5));
    }
}
