using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherObject : MonoBehaviour
{
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mainCamera.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
