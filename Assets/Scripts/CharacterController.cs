using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterController : MonoBehaviour
{
    //public CharacterController2D controller;

    public bool facingRight;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    public Animator animator;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        Flip(); 
    }

   

    void Flip()
    {
        if ((horizontalMove < 0 && facingRight) || (horizontalMove > 0 && !facingRight))
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}

