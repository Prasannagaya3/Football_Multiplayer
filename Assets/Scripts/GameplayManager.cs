using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager gameInstance;
    public BallGameplay BallManager;
    public PlayerGameplay[] PlayerManager;
    public bool isGameRunning;
    public float GameMins, GameSecs;
    private float GameTimer;

    private void Start()
    {
        gameInstance = this;
        isGameRunning = true;
        GameTimer = 0;
    }

    private void Update()
    {
        if (isGameRunning)
        {
            GameTimer += Time.deltaTime;

            GameMins = Mathf.FloorToInt(GameTimer / 60);
            GameSecs = Mathf.FloorToInt(GameTimer % 60);
        }
        else
        {
            ResetGame();
        }
    }

    private void ResetGame()
    {
        isGameRunning = false;
        GameTimer = 0;
        BallManager.ResetBall();
        PlayerResetLoop();
        Time.timeScale = 0;
    }

    private void PlayerResetLoop()
    {
        for(int i = 0; i < PlayerManager.Length; i++)
        {
            PlayerManager[i].ResetPlayer();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
