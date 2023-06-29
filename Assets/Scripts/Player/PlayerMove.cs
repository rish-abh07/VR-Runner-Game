using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float leftrightSpeed = 10.0f;
    public bool canMove = false;
    public bool isJumping = false;
    public GameObject playerObject;
    public bool comingDown = false;
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
                MoveLeft();
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                MoveRight();
            }
            if(Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.Space)))
            {
                jump();
            }
        
        if (isJumping)
        {
            if (!comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if (comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Run");
    }

    public void jump()
    {
        if (canMove)
        {
            if (!isJumping)
            {
                isJumping = true;
                playerObject.GetComponent<Animator>().Play("Jump");
                StartCoroutine(JumpSequence());
            }
        }
    }

    public void MoveLeft()
    {
        if (canMove)
        {
            if (this.gameObject.transform.position.x > LeveLBoundary.leftSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed, Space.World);
        }
    }
    public void MoveRight()
    {
        if (canMove)
        {
            if (this.gameObject.transform.position.x < LeveLBoundary.rightSide)
                transform.Translate(Vector3.left * Time.deltaTime * leftrightSpeed * -1, Space.World);
        }
    }
}
