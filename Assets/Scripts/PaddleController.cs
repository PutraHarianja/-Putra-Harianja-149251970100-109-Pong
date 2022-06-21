using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public int oldSpeed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private Vector3 newSize;
    private Vector3 oldSize;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //ambiil input

        //gerakan objek pake input
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            //gerakan ke atas
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            //gerakan ke bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ActivatePUExtendPaddle(int extension)
    {
        newSize = transform.localScale;
        oldSize = newSize;

        newSize.y *= extension;

        transform.localScale = newSize;

        Invoke("ReturnPaddleSize", 5f);
    }

    public void ReturnPaddleSize()
    {
        transform.localScale = oldSize;
    }

    public void ActivatePUAcceleratePaddle(int acceleration)
    {
        oldSpeed = speed;
        speed *= acceleration;

        Invoke("ReturnPaddleSpeed", 5f);
    }

    public void ReturnPaddleSpeed()
    {
        speed = oldSpeed;
    }
}
