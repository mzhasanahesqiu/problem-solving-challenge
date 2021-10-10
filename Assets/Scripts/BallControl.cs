using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.01f;
    private Rigidbody2D rigidBody2D;
    Vector2 position = new Vector2(0f, 0f);

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rigidBody2D.MovePosition(position);
    }
}