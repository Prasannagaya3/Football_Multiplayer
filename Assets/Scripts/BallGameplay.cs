using UnityEngine;

public class BallGameplay : MonoBehaviour
{
    public static int ScoreSide;

    private Rigidbody2D _ball;
    private float _ballSpeed;

    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _ballSpeed = 20.0f;
        ScoreSide = -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("RightGoal"))
        {
            ScoreSide = 0;
            UIController.UIInstance.ScoreUpdate();
            ResetBall();
        }
        if (collision.transform.CompareTag("LeftGoal"))
        {
            ScoreSide = 1;
            UIController.UIInstance.ScoreUpdate();
            ResetBall();
        }
        if (collision.transform.CompareTag("Stick"))
        {

        }
    }

    private void FixedUpdate()
    {
        BallMotion();
    }

    public void ResetBall()
    {
        transform.position = new Vector2(0, 0);
        _ball.velocity = new Vector2(0, 0);
    }

    private void BallMotion()
    {
        _ball.AddForce(Vector2.right * _ballSpeed * Time.deltaTime);
    }
}
