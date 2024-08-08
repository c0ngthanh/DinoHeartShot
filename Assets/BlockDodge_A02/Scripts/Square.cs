using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private float speed = 5;
    // Update is called once per frame
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down*speed;
    }
}
