using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalValue = Input.GetAxis("Vertical");
        Debug.Log(verticalValue);
    }
}
