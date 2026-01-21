using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int currentCoins = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
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