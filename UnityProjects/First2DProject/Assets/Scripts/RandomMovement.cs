using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{

    public float moveSpeed;
    private int WalkDirection;

    private Rigidbody2D myRigidBody;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (WalkDirection)
            {
                case 0:
                    myRigidBody.velocity = new Vector2(0, moveSpeed * Time.deltaTime);
                    break;
                case 1:
                    myRigidBody.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
                    break;
                case 2:
                    myRigidBody.velocity = new Vector2(moveSpeed * Time.deltaTime, 0);
                    break;
                case 3:
                    myRigidBody.velocity = new Vector2(-moveSpeed * Time.deltaTime, 0);
                    break;
            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;

            myRigidBody.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}
