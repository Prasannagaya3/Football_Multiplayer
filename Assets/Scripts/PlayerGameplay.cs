using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGameplay : MonoBehaviour
{
    public enum PlayerSelection{None, LeftPlayer, RightPlayer};
    public PlayerSelection currentPlayerDetails;
    public InputAction CurrentPlayerAction;
    public Vector2 PlayerMove;
    
    private GameObject currentPlayer;
    private float playerMovementSpeed;

    private void OnEnable()
    {
        CurrentPlayerAction.Enable();
    }

    private void OnDisable()
    {
        CurrentPlayerAction.Disable();
    }

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

        PlayerMove = currentPlayer.GetComponent<Rigidbody2D>().velocity;
    }

    private void FixedUpdate()
    {
        PlayerMove = CurrentPlayerAction.ReadValue<Vector2>();
        currentPlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0, PlayerMove.y * playerMovementSpeed);
    }

    public void ResetPlayer()
    {
        currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x, 0, 0);
    }
}
