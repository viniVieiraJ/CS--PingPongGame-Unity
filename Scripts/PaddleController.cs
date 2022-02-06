using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{


    private Vector3 PaddlePosition;


    private float PaddleY;
    public float PaddleMoveSpeed;
    public float PaddleMoveLimit;

    public bool isPlayer1;


    void Start()
    {
        //Set initial position
        PaddlePosition = transform.position;
    }

    void Update()
    {
        // Get the Y position and set it inside Paddle Transform
        PaddlePosition.y = PaddleY;
        transform.position = PaddlePosition;


        // Verifies if is player 1
        if (isPlayer1)
        {
            // Verifies if Key(W) is pressed and is on boundary to move UP
            if (Input.GetKey(KeyCode.W) && PaddleY < PaddleMoveLimit)
            {   
                PaddleY += PaddleMoveSpeed * Time.deltaTime;
            }


            // Verifies if Key(S) is pressed and is on boundary to move DOWN
            if (Input.GetKey(KeyCode.S) && PaddleY > -PaddleMoveLimit)
            {
                PaddleY -= PaddleMoveSpeed * Time.deltaTime;
            }
        }else
        {
            // Verifies if Key(UpArrow) is pressed and is on boundary to move UP
            if (Input.GetKey(KeyCode.UpArrow) && PaddleY < PaddleMoveLimit)
            {   
                PaddleY += PaddleMoveSpeed * Time.deltaTime;
            }


            // Verifies if Key(DownArrow) is pressed and is on boundary to move DOWN
            if (Input.GetKey(KeyCode.DownArrow) && PaddleY > -PaddleMoveLimit)
            {
                PaddleY -= PaddleMoveSpeed * Time.deltaTime;
            }
        }

    }
}
