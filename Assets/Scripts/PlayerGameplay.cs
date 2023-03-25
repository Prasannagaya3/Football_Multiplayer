using UnityEngine;

public class PlayerGameplay : MonoBehaviour
{
    public enum PlayerSelection{None, LeftPlayer, RightPlayer};

    public PlayerSelection currentPlayerDetails;

    private void Start()
    {
        if(currentPlayerDetails == PlayerSelection.None)
        {
            Debug.Log("NoneSelection");
        }
        if(currentPlayerDetails == PlayerSelection.LeftPlayer)
        {
            Debug.Log("Left");
        }
        if(currentPlayerDetails == PlayerSelection.RightPlayer)
        {
            Debug.Log("Right");
        }
    }
}
