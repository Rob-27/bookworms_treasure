using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int currentCoins = 0;
    public RewardManager rewards;

    public bool gotCoinsForSherlock = false;
    public bool gotCoinsForOdyssey = false;
    public bool gotCoinsForSnowWhite = false;
    public bool gotCoinsForQuotesQuiz = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (rewards.finishedSherlock == true && gotCoinsForSherlock == false)
        {
            AddTenCoins();
            gotCoinsForSherlock = true;
        }


        if (rewards.finishedOdyssey == true && gotCoinsForOdyssey == false)
        {
            AddTenCoins();
            gotCoinsForOdyssey = true;
        }


        if (rewards.finishedSnowWhite == true && gotCoinsForSnowWhite == false)
        {
            AddTenCoins();
            gotCoinsForSnowWhite = true;
        }


        if (rewards.beatQuotesQuiz == true && gotCoinsForQuotesQuiz == false)
        {
            AddTenCoins();
            gotCoinsForQuotesQuiz = true;
        }
    }

    public void AddTenCoins()
    {
        currentCoins += 10;
    }

    public void RemoveTenCoins()
    {
        currentCoins -= 10;
    }

}