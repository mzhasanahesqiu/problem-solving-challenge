using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kotak : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public int scoreValue = 1;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();        
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score += scoreValue;
        Destroy(gameObject);
    }
}
