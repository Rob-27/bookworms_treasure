using UnityEngine;

public class BookPageScroller : MonoBehaviour
{
    int pagePositionY = -575;

    public int spaceBetweenPages = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnToNextPage()
    {
        if (pagePositionY < 0 && pagePositionY >= -575)
        {
            pagePositionY += spaceBetweenPages;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY >= 0)
        {
            pagePositionY = 0;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY < -575)
        {
            pagePositionY = -575;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }
    }

    public void TurnToPreviousPage()
    {
        if (pagePositionY <= 0 && pagePositionY > -575)
        {
            pagePositionY -= spaceBetweenPages;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY > 0)
        {
            pagePositionY = 0;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY <= -575)
        {
            pagePositionY = -575;

            Vector2 newPosition = new Vector2(0, pagePositionY);

            transform.position = newPosition;
        }
    }
}
