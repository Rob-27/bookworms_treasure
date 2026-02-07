using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int currentCoins = 60;
    public RewardManager rewards;
    public GameObject mainView;
    public GameObject bookMessage;
    public GameObject quizMessage;
    public GameObject eBookMenu;
    public GameObject gamesMenu;

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
        if (mainView.activeSelf == true)
        {
            if (rewards.finishedSherlock == true && gotCoinsForSherlock == false)
            {
                AddTwentyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForSherlock = true;
            }


            if (rewards.finishedOdyssey == true && gotCoinsForOdyssey == false)
            {
                AddTwentyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForOdyssey = true;
            }


            if (rewards.finishedSnowWhite == true && gotCoinsForSnowWhite == false)
            {
                AddTwentyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForSnowWhite = true;
            }


            if (rewards.beatQuotesQuiz == true && gotCoinsForQuotesQuiz == false)
            {
                AddTwentyCoins();
                gamesMenu.SetActive(false);
                quizMessage.SetActive(true);
                gotCoinsForQuotesQuiz = true;
            }
        }
    }

    public void AddTwentyCoins()
    {
        currentCoins += 20;
    }

    public void RemoveFiveCoins()
    {
        currentCoins -= 5;
    }

    public void RemoveTenCoins()
    {
        currentCoins -= 10;
    }

}