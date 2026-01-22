using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int scoredPoints = 0;

    private static TMP_Text scoreText;

    public RewardManager rewards;

    void Start()
    {
        scoreText = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (scoredPoints == 8)
        {
            rewards.beatQuotesQuiz = true;
        }
    }

    public static void AddPoint()
    {
        scoredPoints++;

        if (scoreText != null && scoredPoints != 10)
        {
            scoreText.text = scoredPoints.ToString();
        }

        else if (scoredPoints == 9)
        {
            scoreText.text = "8";
        }
    }

    public static void ResetScore()
    {
        scoredPoints = 0;
    }
}
