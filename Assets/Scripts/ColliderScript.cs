using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnTriggerEnter()
    // {
    //     Debug.Log("すれ違った");
    // }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
