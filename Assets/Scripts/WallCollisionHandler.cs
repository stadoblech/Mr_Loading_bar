using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisionHandler : MonoBehaviour
{
    bool contacted = false;

    public Action barAndWallCollisionAction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (contacted)
            return;
        foreach(ContactPoint2D c in collision.contacts)
        {
            if(c.collider.tag == Tags.LoadingBarBorder)
            {
                if (barAndWallCollisionAction != null)
                    barAndWallCollisionAction();
                contacted = true;
            }
        }
    }
}
