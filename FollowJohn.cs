using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowJohn : MonoBehaviour
{
    public GameObject john;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Max(pos.y, john.transform.position.y);
        transform.position = pos;
    }
}
