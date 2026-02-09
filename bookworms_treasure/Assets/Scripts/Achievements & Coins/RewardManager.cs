using UnityEngine;

public class RewardManager : MonoBehaviour
{
    public bool finishedSherlock = false;
    public bool finishedOdyssey = false;
    public bool finishedSnowWhite = false;
    public bool beatQuotesQuiz = false;

    public bool gotRewardsForSherlock = false;
    public bool gotRewardsForOdyssey = false;
    public bool gotRewardsForSnowWhite = false;
    public bool gotRewardsForQuiz = false;

    public GameObject rewardForSherlock1;
    public GameObject rewardForSherlock2;
    public GameObject rewardForSherlock3;
    public GameObject rewardForSherlock4;

    public GameObject rewardForOdyssey1;
    public GameObject rewardForOdyssey2;
    public GameObject rewardForOdyssey3;
    public GameObject rewardForOdyssey4;

    public GameObject rewardForSnowWhite1;
    public GameObject rewardForSnowWhite2;
    public GameObject rewardForSnowWhite3;
    public GameObject rewardForSnowWhite4;

    public GameObject rewardForQuiz1;
    public GameObject rewardForQuiz2;
    public GameObject rewardForQuiz3;
    public GameObject rewardForQuiz4;


    // Update is called once per frame
    void Update()
    {
        if (finishedSherlock == true && gotRewardsForSherlock == false)
        {
            rewardForSherlock1.SetActive(true);
            rewardForSherlock2.SetActive(true);
            rewardForSherlock3.SetActive(true);
            rewardForSherlock4.SetActive(true);
            gotRewardsForSherlock = true;
        }

        if (finishedOdyssey == true && gotRewardsForOdyssey == false)
        {
            rewardForOdyssey1.SetActive(true);
            rewardForOdyssey2.SetActive(true);
            rewardForOdyssey3.SetActive(true);
            rewardForOdyssey4.SetActive(true);
            gotRewardsForOdyssey = true;
        }

        if (finishedSnowWhite == true && gotRewardsForSnowWhite == false)
        {
            rewardForSnowWhite1.SetActive(true);
            rewardForSnowWhite2.SetActive(true);
            rewardForSnowWhite3.SetActive(true);
            rewardForSnowWhite4.SetActive(true);
            gotRewardsForSnowWhite = true;
        }

        if (beatQuotesQuiz == true && gotRewardsForQuiz == false)
        {
            rewardForQuiz1.SetActive(true);
            rewardForQuiz2.SetActive(true);
            rewardForQuiz3.SetActive(true);
            rewardForQuiz4.SetActive(true);
            gotRewardsForQuiz = true;
        }
    }
}
