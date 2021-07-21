using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Animator myAnimator = new Animator();
    private Vector2 myMovementInput = new Vector2();

    private Vector3 startScale;
    private void Start()
    {
        startScale = transform.localScale;
    }

    private void Update()
    {
       

        if(Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetBool("W", true);
            myAnimator.SetTrigger("Trigger W");

        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            myAnimator.SetBool("W", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myAnimator.SetBool("S", true);
            myAnimator.SetTrigger("Trigger S");

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            myAnimator.SetBool("S", false);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = startScale;

            myAnimator.SetBool("D", true);
            myAnimator.SetTrigger("Trigger D");

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            myAnimator.SetBool("D", false);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(startScale.x *-1, startScale.y, startScale.z);

            myAnimator.SetBool("D", true);
            myAnimator.SetTrigger("Trigger D");

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (!Input.GetKey(KeyCode.D))
            {
                myAnimator.SetBool("D", false);
            }
        }

    }



}
