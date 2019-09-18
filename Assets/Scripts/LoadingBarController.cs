using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingBarController : MonoBehaviour
{
    public Action gameFinished;

    bool finished = false;
        
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (finished)
            return;
        if(coll.tag == Tags.endOfLoadingTrigger)
        {
            if (gameFinished != null)
                gameFinished();
        }
    }
}
