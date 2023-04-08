using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public MeshRenderer mesh;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0);
    }
}
