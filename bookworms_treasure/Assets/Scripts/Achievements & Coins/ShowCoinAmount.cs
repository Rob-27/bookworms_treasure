using UnityEngine;
using TMPro;

public class ShowCoinAmount : MonoBehaviour
{
    public CoinCounter coins;

    private static TMP_Text coinDisplay;

    void Awake()
    {
        coinDisplay = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        coinDisplay.text = coins.currentCoins.ToString();
    }

}
