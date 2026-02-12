using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject startingScreen;
    public GameObject backgroundMusic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("EnterGame", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterGame()
    {
        startingScreen.SetActive(false);
        backgroundMusic.SetActive(true);
    }
}
