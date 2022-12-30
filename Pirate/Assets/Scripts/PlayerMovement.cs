using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    private Animator a;
    private SpriteRenderer s;
    private BoxCollider2D b;
    [SerializeField] private LayerMask ground;

   private enum MovementState { moving, jumping, falling, melting };
    private float Xline = 0f;
    private float Yline = 0f;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        s = GetComponent<SpriteRenderer>();
        a = GetComponent<Animator>();
        b = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float Xline = Input.GetAxisRaw("Horizontal");
        rigid.freezeRotation = true;
        rigid.velocity = new Vector2(Xline * 7f, rigid.velocity.y);
        if ((Input.GetButtonDown("Jump") && Ground()) || (Input.GetKeyDown(KeyCode.W) && Ground())|| (Input.GetKeyDown(KeyCode.UpArrow) && Ground()))
        {
            rigid.velocity = new Vector3(rigid.velocity.x, 14f);
        }
        if (Xline > 0f)
        {
            s.flipX = false;
        }
        
        if (Xline < 0f)
        {
            s.flipX = true;
        }
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        state = MovementState.moving;
        if (rigid.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rigid.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            state = MovementState.melting;
            print(state);
        }
        a.SetInteger("state", (int)state);
    }

    private bool Ground()
    {
        return Physics2D.BoxCast(b.bounds.center, b.bounds.size, 0f, Vector2.down, .1f, ground);
    }
}
