using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpawnPoint;
    public GameObject Plane;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < Plane.transform.position.y-10)
        {
            transform.position = SpawnPoint.transform.position;
        }
    }
}
