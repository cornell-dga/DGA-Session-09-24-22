using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJohn : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if(Input.GetKey(KeyCode.LeftArrow)) {
            rb.position -= new Vector2(speed*Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            rb.position += new Vector2(speed*Time.deltaTime, 0);
        }
    }
}
