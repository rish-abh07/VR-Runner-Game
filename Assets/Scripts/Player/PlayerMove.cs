using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float leftrightSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed , Space.World);


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LeveLBoundary.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if(this.gameObject.transform.position.x < LeveLBoundary.rightSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed * -1, Space.World);
        }
    }
}
