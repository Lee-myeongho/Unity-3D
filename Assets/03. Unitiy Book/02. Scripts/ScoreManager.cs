using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI currentScoreUI;
    public TextMeshProUGUI bestScoreUI;

    private int currentScore;
    private int bestScore;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);

        bestScoreUI.text = "최고 점수:" + bestScore;
    }

    public void SetScore(int value)
    {
        currentScore = value;

        currentScoreUI.text = "현재 점수" + currentScore;


        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "최고 점수" + bestScore;

            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

    public int GetScore()
    {
        return currentScore;
    }
}
