using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Animator animator;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw(PAP.axisXinput);

        animator.SetFloat(PAP.moveX, moveX);

        bool isMoving = !Mathf.Approximately(moveX, 0f);

        animator.SetBool(PAP.isMoving, isMoving);


        //Doing a jump
        bool isJumpKeyPressed = Input.GetButtonDown("Jump");


        if (isJumpKeyPressed)
        {
            animator.SetTrigger(PAP.JumpTriggerName);
        }
        else
        {
            animator.ResetTrigger(PAP.JumpTriggerName);
        }
    }

    void FixedUpdate()
    {
        //Debug.Log("JUMPPPP");
        float forceX = animator.GetFloat(PAP.forceX);

        float impulseY = animator.GetFloat(PAP.impulseY);
        float impulseX = animator.GetFloat(PAP.impulseX);

        if (forceX != 0)
        {
            rb.AddForce(new Vector2(forceX, 0) * Time.deltaTime);
        }
        //float impulseY = animator.GetFloat(PAP.impulseY);


        if (impulseY != 0 || impulseX != 0)
        {
            float xDirectionSign = Mathf.Sign(transform.localScale.x);
            Vector2 impulseVector = new Vector2(xDirectionSign * impulseX, impulseY);

            //rb.AddForce(new Vector2(0, impulseY), ForceMode2D.Impulse);
            rb.AddForce(impulseVector, ForceMode2D.Impulse);
            animator.SetFloat(PAP.impulseY, 0);
            animator.SetFloat(PAP.impulseX, 0);
        }

    }
}
