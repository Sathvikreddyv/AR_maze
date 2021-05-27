using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teleport1;
    public GameObject portal2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider teleport1)
    {
        teleport1.transform.position = portal2.transform.position;
    } 
}
