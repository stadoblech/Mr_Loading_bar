using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float torque;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        Invoke("unfreezeRotation",1f);
    }

    private void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        rigid.AddTorque(-torque * turn);
    }

    void unfreezeRotation()
    {
        rigid.constraints = RigidbodyConstraints2D.None;
    }
}
