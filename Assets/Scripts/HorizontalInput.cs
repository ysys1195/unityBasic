using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        Debug.Log(horizontalValue);
    }
}
