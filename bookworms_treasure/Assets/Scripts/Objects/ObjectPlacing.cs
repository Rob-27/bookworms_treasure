using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class ObjectPlacing : MonoBehaviour
{
    public GameObject poolTable;
    public GameObject armchair;
    public GameObject bookshelf;

    public bool poolTableButtonClicked = false;
    public bool armchairButtonClicked = false;
    public bool bookshelfButtonClicked = false;
    public bool noObjectToPlace = true;
    public bool deleteObjectMode = false;
    public bool flipObjectMode = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (poolTableButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(poolTable);
            PlaceNoObject();
        }

        if (armchairButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(armchair);
            PlaceNoObject();
        }

        if (bookshelfButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bookshelf);
            PlaceNoObject();
        }

        if (deleteObjectMode == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
        }
    }

    public void PoolTableButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = true;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
    }

    public void ArmchairButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = true;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
    }

    public void BookshelfButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = true;
        deleteObjectMode = false;
        flipObjectMode = false;
    }

    public void PlaceNoObject()
    {
        noObjectToPlace = true;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
    }

    public void DeleteObject()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = true;
        flipObjectMode = false;
    }

    public void FlipObject()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = true;
    }
}
