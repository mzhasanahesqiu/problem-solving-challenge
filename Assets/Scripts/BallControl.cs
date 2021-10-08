using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float xInitialForce;
    public float yInitialForce;

    void ResetBall()
    {
        transform.position = Vector2.zero;
        rigidBody.velocity = Vector2.zero;
    }

    void PushBall()
    {
        float randomDirection = Random.Range(0, 4);

        if (randomDirection < 1.0f)
        {
            rigidBody.AddForce(new Vector2(-xInitialForce, -yInitialForce));
        }
        else if (randomDirection < 2.0f)
        {
            rigidBody.AddForce(new Vector2(xInitialForce, -yInitialForce));
        }
        else if (randomDirection < 3.0f)
        {
            rigidBody.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            rigidBody.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("PushBall", 1);
    }
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        RestartGame();
    }
}
