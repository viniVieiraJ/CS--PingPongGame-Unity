using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D BallRB;

    public Vector2 RBVelocity;

    public float BallSpeed;

    void Start()
    {
        RBVelocity.x = -BallSpeed; 

        BallRB.velocity = RBVelocity;             
    }

    void Update()
    {
        
    }
}
