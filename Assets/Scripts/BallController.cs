using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public Collider2D LeftPaddle;
    public Collider2D RightPaddle;
    public int LastHitPaddle;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }


    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == LeftPaddle )
        {
            LastHitPaddle = 0;
        }

        if (collision.collider == RightPaddle)
        {
            LastHitPaddle = 1;
        }
    }
}
