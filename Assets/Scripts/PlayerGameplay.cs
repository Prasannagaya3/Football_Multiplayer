using UnityEngine;

public class PlayerGameplay : MonoBehaviour
{
    public enum PlayerSelection{None, LeftPlayer, RightPlayer};
    public PlayerSelection currentPlayerDetails;

    private GameObject currentPlayer;
    private float playerMovementSpeed;

    private void Start()
    {
        currentPlayer = this.gameObject;
        playerMovementSpeed = 20f;

        if (currentPlayerDetails == PlayerSelection.None)
        {
            currentPlayer.name = "TBD";
        }
        if(currentPlayerDetails == PlayerSelection.LeftPlayer)
        {
            currentPlayer.name = "Left Player";
        }
        if(currentPlayerDetails == PlayerSelection.RightPlayer)
        {
            currentPlayer.name = "Right Player";
        }
    }

    private void Update()
    {
        PlayerMotion();
    }

    public void ResetPlayer()
    {
        currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x, 0, 0);
    }

    private void PlayerMotion()
    {
        if(currentPlayerDetails == PlayerSelection.LeftPlayer)
        {
            Vector2 playerMove = currentPlayer.GetComponent<Rigidbody2D>().velocity;

            if (Input.GetKey(KeyCode.W))
            {
                playerMove.y = playerMovementSpeed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                playerMove.y = -playerMovementSpeed;
            }
            else
            {
                playerMove.y = 0;
            }
            currentPlayer.GetComponent<Rigidbody2D>().velocity = playerMove;
        }
        else if(currentPlayerDetails == PlayerSelection.RightPlayer)
        {
            Vector2 playerMove = currentPlayer.GetComponent<Rigidbody2D>().velocity;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerMove.y = playerMovementSpeed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                playerMove.y = -playerMovementSpeed;
            }
            else
            {
                playerMove.y = 0;
            }
            currentPlayer.GetComponent<Rigidbody2D>().velocity = playerMove;
        }
    }
}
