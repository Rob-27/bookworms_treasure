using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int currentCoins = 100;
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

    public bool coinsUnder5 = false;
    public bool noCoinsLeft = false;

    void Start()
    {
    }

    void Update()
    {
        if (currentCoins >= 5)
        {
            coinsUnder5 = false;
            noCoinsLeft = false;
        }

        else if (currentCoins < 5 && currentCoins > 0)
        {
            coinsUnder5 = true;
            noCoinsLeft = false;
        }

        else if (currentCoins == 0)
        {
            noCoinsLeft = true;
            coinsUnder5 = true;
        }

        if (mainView.activeSelf == true)
        {
            if (rewards.finishedSherlock == true && gotCoinsForSherlock == false)
            {
                AddThirtyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForSherlock = true;
            }


            if (rewards.finishedOdyssey == true && gotCoinsForOdyssey == false)
            {
                AddThirtyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForOdyssey = true;
            }


            if (rewards.finishedSnowWhite == true && gotCoinsForSnowWhite == false)
            {
                AddThirtyCoins();
                eBookMenu.SetActive(false);
                bookMessage.SetActive(true);
                gotCoinsForSnowWhite = true;
            }


            if (rewards.beatQuotesQuiz == true && gotCoinsForQuotesQuiz == false)
            {
                AddThirtyCoins();
                gamesMenu.SetActive(false);
                quizMessage.SetActive(true);
                gotCoinsForQuotesQuiz = true;
            }
        }
    }

    public void AddThirtyCoins()
    {
        currentCoins += 30;
        AudioSource coinSound = GetComponent<AudioSource>();
        coinSound.Play();
    }

    public void RemoveFiveCoins()
    {
        currentCoins -= 5;
        AudioSource coinSound = GetComponent<AudioSource>();
        coinSound.Play();
    }

    public void RemoveTenCoins()
    {
        currentCoins -= 10;
        AudioSource coinSound = GetComponent<AudioSource>();
        coinSound.Play();
    }

}