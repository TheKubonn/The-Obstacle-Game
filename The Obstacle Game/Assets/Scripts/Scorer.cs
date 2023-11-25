using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hitCount = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hitCount++;
            Debug.Log("You've bumped this many times: " + hitCount);
        }
    }
}
