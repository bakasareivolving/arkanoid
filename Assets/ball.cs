using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 100.0f;
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    float hitfactor(Vector2 ballpos, Vector2 racketpos,float racketWidth) 
    {
        // ascci art:
        //
        // 1 -0.5 0 0.5 1 <-x value
        //================<- racket
        //
        return (ballpos.x - racketpos.x) / racketWidth;
    } 
    void OnCollisionEnter2D(Collision2D col)
    {
        // hit the Racket?
        if (col.gameObject.name == "racket") 
        {
            // Calculate his Factor
            float x=hitfactor(transform.position,
                        col.transform.position,
                        col.collider.bounds.size.x);
            //calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;
            //set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    } 
  
}