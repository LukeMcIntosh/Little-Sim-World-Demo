using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MOVE_DIRECTION
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}


public class PlayerInput : MonoBehaviour
{
    public PlayerClothingManager clotheManager;

    [SerializeField] private Animator myAnimator = new Animator();
    [HideInInspector] public Vector2 myMovementInput { get; private set; }

    private void Start()
    {
    }

    private void Update()
    {    
        if (Input.GetKeyDown(KeyCode.W))
        {
            myMovementInput += new Vector2(0, 1);
            SetAnimatorBasedOnVec();
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            myAnimator.SetBool("W", false);
            myMovementInput -= new Vector2(0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myMovementInput += new Vector2(0, -1);
            SetAnimatorBasedOnVec();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            myAnimator.SetBool("S", false);
            myMovementInput -= new Vector2(0, -1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myMovementInput += new Vector2(1, 0);
            SetAnimatorBasedOnVec();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            myAnimator.SetBool("D", false);
            myMovementInput -= new Vector2(1, 0);
            SetAnimatorBasedOnVec();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myMovementInput += new Vector2(-1, 0);
            SetAnimatorBasedOnVec();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
             myAnimator.SetBool("A", false);
            myMovementInput -= new Vector2(-1, 0);
            SetAnimatorBasedOnVec();
        }     
    }

    private void SetAnimatorBasedOnVec()
    {
        if(myMovementInput.x > 0)
        {
            myAnimator.SetBool("D", true);
            myAnimator.SetTrigger("Trigger D");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.RIGHT);
        }
        else if(myMovementInput.x < 0)
        {
            myAnimator.SetBool("A", true);
            myAnimator.SetTrigger("Trigger A");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.LEFT);
        }

        else if(myMovementInput.y > 0)
        {
            myAnimator.SetBool("W", true);
            myAnimator.SetTrigger("Trigger W");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.UP);
        }
        else if (myMovementInput.y < 0)
        {
            myAnimator.SetBool("S", true);
            myAnimator.SetTrigger("Trigger S");
            clotheManager.SetCurrentInput(MOVE_DIRECTION.DOWN);
        }
    }

}
