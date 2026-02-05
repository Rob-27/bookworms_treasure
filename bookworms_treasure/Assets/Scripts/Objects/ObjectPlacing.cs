using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ObjectPlacing : MonoBehaviour
{
    public GameObject poolTable;
    public GameObject armchair;
    public GameObject bookshelf;
    public GameObject plant;
    public GameObject couch;
    public GameObject wavingCat;

    public Button poolTableButton;
    public Button armchairButton;
    public Button bookshelfButton;
    public Button plantButton;
    public Button couchButton;
    public Button wavingCatButton;

    public GameObject poolTablePreview;
    public GameObject armchairPreview;
    public GameObject bookshelfPreview;
    public GameObject plantPreview;
    public GameObject couchPreview;
    public GameObject wavingCatPreview;

    public bool poolTableButtonClicked = false;
    public bool armchairButtonClicked = false;
    public bool bookshelfButtonClicked = false;
    public bool plantButtonClicked = false;
    public bool couchButtonClicked = false;
    public bool wavingCatButtonClicked = false;
    public bool noObjectToPlace = true;
    public bool deleteObjectMode = false;
    public bool flipObjectMode = false;
    public bool moveObjectMode = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deleteObjectMode == true)
        {
            poolTableButton.enabled = false;
            armchairButton.enabled = false;
            bookshelfButton.enabled = false;
            plantButton.enabled = false;
            couchButton.enabled = false;
            wavingCatButton.enabled = false;
        }

        if (flipObjectMode == true)
        {
            poolTableButton.enabled = false;
            armchairButton.enabled = false;
            bookshelfButton.enabled = false;
            plantButton.enabled = false;
            couchButton.enabled = false;
            wavingCatButton.enabled = false;
        }

        if (moveObjectMode == true)
        {
            poolTableButton.enabled = false;
            armchairButton.enabled = false;
            bookshelfButton.enabled = false;
            plantButton.enabled = false;
            couchButton.enabled = false;
            wavingCatButton.enabled = false;
        }

        if (noObjectToPlace == true)
        {
            poolTableButton.enabled = true;
            armchairButton.enabled = true;
            bookshelfButton.enabled = true;
            plantButton.enabled = true;
            couchButton.enabled = true;
            wavingCatButton.enabled = true;
        }

        if (poolTableButtonClicked == true)
        {
            poolTablePreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(poolTable);
                poolTablePreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (armchairButtonClicked == true)
        {
            armchairPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(armchair);
                armchairPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (bookshelfButtonClicked == true)
        {
            bookshelfPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(bookshelf);
                bookshelfPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (plantButtonClicked == true)
        {
            plantPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(plant);
                plantPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (couchButtonClicked == true)
        {
            couchPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(couch);
                couchPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (wavingCatButtonClicked == true)
        {
            wavingCatPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(wavingCat);
                wavingCatPreview.SetActive(false);
                PlaceNoObject();
            }
        }
    }

    public void PoolTableButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = true;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void ArmchairButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = true;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void BookshelfButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        plantButtonClicked = false;
        bookshelfButtonClicked = true;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void PlantButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = true;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void CouchButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = true;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void WavingCatButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = true;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void PlaceNoObject()
    {
        noObjectToPlace = true;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void DeleteObject()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = true;
        flipObjectMode = false;
        moveObjectMode = false;
    }

    public void FlipObject()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = true;
        moveObjectMode = false;
    }

    public void MoveObject()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = true;
    }
}
