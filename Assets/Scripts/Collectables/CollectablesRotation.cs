using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private  float rotationSpeed = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
