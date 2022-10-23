using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricksscript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "ball")  {
            Destroy(gameObject);
        }
    }
}