using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Rigidbody2D playerRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        float horizontalMove = moveSpeed * Input.GetAxis("Horizontal");
        playerRigidBody.velocity = new Vector2(horizontalMove, playerRigidBody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce);
        }
    }
}
