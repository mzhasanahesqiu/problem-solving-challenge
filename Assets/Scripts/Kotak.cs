using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kotak : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public static int score;
    public int scoreValue = 1;
    public Text _score;
    Text text;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        text = GetComponent<Text>();
        score = 0;
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
            score += scoreValue;
            Destroy(gameObject);
    }

    void Update()
    {
        _score.text = "Skor: " + score;
    }
}
