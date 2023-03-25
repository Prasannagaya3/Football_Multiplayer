using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGameplay : MonoBehaviour
{
    private Rigidbody2D _ball;
    private float _ballSpeed;

    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _ballSpeed = 2.0f;
        ResetBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("RightGoal"))
        {
            Debug.Log("Right Goal");
            ResetBall();
        }
        if (collision.transform.CompareTag("LeftGoal"))
        {
            Debug.Log("Left Goal");
            ResetBall();
        }
        if (collision.transform.CompareTag("Stick"))
        {
            BallMotion();
        }
    }

    private void Update()
    {
        BallMotion();
    }

    private void ResetBall()
    {
        Transform currentBall;
        currentBall = _ball.GetComponent<Transform>();

        currentBall.position = new Vector2(0, 0);
        currentBall.position = new Vector2(0, 0);

        _ball.velocity = new Vector2(0, 0);
        _ball.angularVelocity = 0;
    }

    private void BallMotion()
    {
        _ball.AddForce(Vector2.right * _ballSpeed);
    }
}
