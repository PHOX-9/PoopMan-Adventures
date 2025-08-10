using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;

    public float horizontal = 0f;

    public float speed = 0f;

    public bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed; //gives value -1 on pressing left and 1 on pressing right

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        //Move our Character
        controller.Move(horizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
