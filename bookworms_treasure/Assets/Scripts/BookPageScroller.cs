using UnityEngine;

public class BookPageScroller : MonoBehaviour
{
    int pagePositionY = -575;

    public int firstPagePositionY = 0;

    public int lastPagePositionY = 475;

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
        if (pagePositionY < firstPagePositionY && pagePositionY >= lastPagePositionY)
        {
            pagePositionY += spaceBetweenPages;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY >= firstPagePositionY)
        {
            pagePositionY = firstPagePositionY;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY < lastPagePositionY)
        {
            pagePositionY = lastPagePositionY;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }
    }

    public void TurnToPreviousPage()
    {
        if (pagePositionY <= firstPagePositionY && pagePositionY > lastPagePositionY)
        {
            pagePositionY -= spaceBetweenPages;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY > firstPagePositionY)
        {
            pagePositionY = firstPagePositionY;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }

        else if (pagePositionY <= lastPagePositionY)
        {
            pagePositionY = lastPagePositionY;

            Vector2 newPosition = new Vector2(-100, pagePositionY);

            transform.position = newPosition;
        }
    }
}
