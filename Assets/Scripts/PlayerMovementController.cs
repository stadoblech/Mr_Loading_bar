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
        float turn = 0;
#if UNITY_EDITOR
        turn = Input.GetAxis("Horizontal");
#endif

#if UNITY_ANDROID
        foreach (Touch touch in Input.touches)
        {
            
            if ((touch.position.x > Screen.width / 2) && (touch.phase == TouchPhase.Stationary))
            {
                turn = 1;
            }else if ((touch.position.x < Screen.width / 2) && (touch.phase == TouchPhase.Stationary))
            {
                turn = -1;
            }
        }
#endif
        rigid.AddTorque(-torque * turn);
    }



    void unfreezeRotation()
    {
        rigid.constraints = RigidbodyConstraints2D.None;
    }


}
