using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public PlayerClothingManager clotheManager;
    [SerializeField] private Animator myAnimator = new Animator();
    private Vector2 myMovementInput = new Vector2();

    private void Start()
    {
    }

    private void Update()
    {
       

        if(Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetBool("W", true);
            myAnimator.SetTrigger("Trigger W");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.UP);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            myAnimator.SetBool("W", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myAnimator.SetBool("S", true);
            myAnimator.SetTrigger("Trigger S");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.DOWN);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            myAnimator.SetBool("S", false);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            myAnimator.SetBool("D", true);
            myAnimator.SetTrigger("Trigger D");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.RIGHT);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            myAnimator.SetBool("D", false);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
           

            myAnimator.SetBool("A", true);
            myAnimator.SetTrigger("Trigger A");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.LEFT);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
             myAnimator.SetBool("A", false);
        }

    }



}
