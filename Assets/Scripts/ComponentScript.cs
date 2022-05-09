using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = gameObject.GetComponent<Camera>();

        camera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
