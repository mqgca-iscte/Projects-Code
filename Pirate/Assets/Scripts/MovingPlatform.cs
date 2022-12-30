using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.name == "Player")
        {
            c.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.name == "Player")
        {
            c.gameObject.transform.SetParent(null);
        }
    }

}
