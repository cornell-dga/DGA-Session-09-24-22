using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapJohn : MonoBehaviour
{
    public float left;
    public float right;

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 pos = rb.position;
        float w = right - left;
        pos.x = ((pos.x - left + w) % w) + left;
        rb.position = pos;
    }
}
