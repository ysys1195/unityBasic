using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherComponent : MonoBehaviour
{
    public Camera cameraComponent;
    // Start is called before the first frame update
    void Start()
    {
        cameraComponent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
