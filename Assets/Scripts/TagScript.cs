using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameObject item = GameObject.FindWithTag("Item");

        // Debug.Log(item.name);

        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach(GameObject item in items)
        {
            Debug.Log(item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
