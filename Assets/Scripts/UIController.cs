using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController UIInstance;
    [SerializeField] private GameObject[] UIPanel;
    [SerializeField] private TextMeshProUGUI[] PlayerScore;
    [SerializeField] private TextMeshProUGUI GameTimerDisplay, PlayerScoreDisplay, WinningMessage;
    private int leftScore, rightScore, scoreLimit;

    private void Awake()
    {
        UIInstance = this;
    }

    private void Start()
    {
        scoreLimit = 1;
        UIPanelControl(0);
        ScoreReset();
    }

    private void UIPanelControl(int count)
    {
        for(int i = 0; i < UIPanel.Length; i++)
        {
            if(i == count)
            {
                UIPanel[i].SetActive(true);
            }
            else
            {
                UIPanel[i].SetActive(false);
            }
        }
    }

    public void ScoreUpdate()
    {
       OnScreenScoreUpdate();
    }

    private void OnScreenScoreUpdate()
    {
        if (BallGameplay.ScoreSide == 0)
        {
            leftScore++;
            PlayerScore[0].text = leftScore.ToString();
        }
        else
        {
            rightScore++;
            PlayerScore[1].text = rightScore.ToString();
        }

        if (leftScore == scoreLimit || rightScore == scoreLimit)
        {
            UIPanelControl(1);
            ResultUpdate();
        }
    }

    private void ScoreReset()
    {
        leftScore = 0;
        rightScore = 0;
        for(int i = 0; i < PlayerScore.Length; i++)
        {
            PlayerScore[i].text = leftScore.ToString();
        }
        PlayerScoreDisplay.text = leftScore.ToString();
        WinningMessage.text = " ";
    }

    public void ResultUpdate()
    {
        GameplayManager.gameInstance.isGameRunning = false;
        GameTimerDisplay.text = GameplayManager.gameInstance.GameMins.ToString() + ":" + GameplayManager.gameInstance.GameSecs.ToString();

        if(leftScore < rightScore)
        {
            PlayerScoreDisplay.text = rightScore.ToString();
            WinningMessage.text = "Congratulation Right Player!!!";
        }
        else
        {
            PlayerScoreDisplay.text = leftScore.ToString();
            WinningMessage.text = "Congratulation Left Player!!!";
        }
    }

    public void RestartGame()
    {
        GameplayManager.gameInstance.Restart();
        UIPanelControl(0);
    }
}
