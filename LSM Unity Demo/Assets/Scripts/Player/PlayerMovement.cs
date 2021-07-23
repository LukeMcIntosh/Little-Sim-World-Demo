using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float maxSpeed;
    public float accelerationSpeed;

    private PlayerInput playerInput;
    private Rigidbody2D myRb;
    private Vector2 lastMovement;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        myRb = GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
        if (playerInput.myMovementInput == Vector2.zero || lastMovement != playerInput.myMovementInput)
        {
            myRb.velocity = Vector2.zero;

        }

        if (myRb.velocity.magnitude < maxSpeed)
        {
            myRb.AddForce(playerInput.myMovementInput * accelerationSpeed * Time.deltaTime, ForceMode2D.Force);
        }



        lastMovement = playerInput.myMovementInput;
    }

}
