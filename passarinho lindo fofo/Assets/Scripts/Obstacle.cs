using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed = 3.5f;

    Rigidbody2D rB;

    private void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (transform.position.x < -GameManager.instance.ScreenBounds.x)
        {
            Destroy(gameObject);
        }

        rB.velocity = Vector2.left * speed;
    }
}
