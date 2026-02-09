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
    public GameObject workTable;
    public GameObject grammophone;
    public GameObject chest;
    public GameObject dog;
    public GameObject statue;
    public GameObject mirror;

    public Button poolTableButton;
    public Button armchairButton;
    public Button bookshelfButton;
    public Button plantButton;
    public Button couchButton;
    public Button wavingCatButton;
    public Button workTableButton;
    public Button grammophoneButton;
    public Button chestButton;
    public Button dogButton;
    public Button statueButton;
    public Button mirrorButton;

    public GameObject poolTablePreview;
    public GameObject armchairPreview;
    public GameObject bookshelfPreview;
    public GameObject plantPreview;
    public GameObject couchPreview;
    public GameObject wavingCatPreview;
    public GameObject workTablePreview;
    public GameObject grammophonePreview;
    public GameObject chestPreview;
    public GameObject dogPreview;
    public GameObject statuePreview;
    public GameObject mirrorPreview;

    public bool poolTableButtonClicked = false;
    public bool armchairButtonClicked = false;
    public bool bookshelfButtonClicked = false;
    public bool plantButtonClicked = false;
    public bool couchButtonClicked = false;
    public bool wavingCatButtonClicked = false;
    public bool workTableButtonClicked = false;
    public bool grammophoneButtonClicked = false;
    public bool chestButtonClicked = false;
    public bool dogButtonClicked = false;
    public bool statueButtonClicked = false;
    public bool mirrorButtonClicked = false;
    public bool noObjectToPlace = true;
    public bool deleteObjectMode = false;
    public bool flipObjectMode = false;
    public bool moveObjectMode = false;

    // Update is called once per frame
    void Update()
    {
        if (deleteObjectMode == true)
        {
            DisableButtons();
        }

        if (flipObjectMode == true)
        {
            DisableButtons();
        }

        if (moveObjectMode == true)
        {
            DisableButtons();
        }

        if (noObjectToPlace == true)
        {
            EnableButtons();
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

        if (workTableButtonClicked == true)
        {
            workTablePreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(workTable);
                workTablePreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (grammophoneButtonClicked == true)
        {
            grammophonePreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(grammophone);
                grammophonePreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (chestButtonClicked == true)
        {
            chestPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(chest);
                chestPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (dogButtonClicked == true)
        {
            dogPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(dog);
                dogPreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (statueButtonClicked == true)
        {
            statuePreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(statue);
                statuePreview.SetActive(false);
                PlaceNoObject();
            }
        }

        if (mirrorButtonClicked == true)
        {
            mirrorPreview.SetActive(true);

            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Instantiate(mirror);
                mirrorPreview.SetActive(false);
                PlaceNoObject();
            }
        }
    }

    public void PoolTableButton()
    {
        SetAllStatesToFalse();
        poolTableButtonClicked = true;
    }

    public void ArmchairButton()
    {
        SetAllStatesToFalse();
        armchairButtonClicked = true;
    }

    public void BookshelfButton()
    {
        SetAllStatesToFalse();
        bookshelfButtonClicked = true;
    }

    public void PlantButton()
    {
        SetAllStatesToFalse();
        plantButtonClicked = true;
    }

    public void CouchButton()
    {
        SetAllStatesToFalse();
        couchButtonClicked = true;
    }

    public void WavingCatButton()
    {
        SetAllStatesToFalse();
        wavingCatButtonClicked = true;
    }

    public void WorkTableButton()
    {
        SetAllStatesToFalse();
        workTableButtonClicked = true;
    }

    public void GrammophoneButton()
    {
        SetAllStatesToFalse();
        grammophoneButtonClicked = true;
    }

    public void ChestButton()
    {
        SetAllStatesToFalse();
        chestButtonClicked = true;
    }

    public void DogButton()
    {
        SetAllStatesToFalse();
        dogButtonClicked = true;
    }

    public void StatueButton()
    {
        SetAllStatesToFalse();
        statueButtonClicked = true;
    }

    public void MirrorButton()
    {
        SetAllStatesToFalse();
        mirrorButtonClicked = true;
    }

    public void PlaceNoObject()
    {
        SetAllStatesToFalse();
        noObjectToPlace = true;
    }

    public void DeleteObject()
    {
        SetAllStatesToFalse();
        deleteObjectMode = true;
    }

    public void FlipObject()
    {
        SetAllStatesToFalse();
        flipObjectMode = true;
    }

    public void MoveObject()
    {
        SetAllStatesToFalse();
        moveObjectMode = true;
    }

    public void DisableButtons()
    {
        poolTableButton.enabled = false;
        armchairButton.enabled = false;
        bookshelfButton.enabled = false;
        plantButton.enabled = false;
        couchButton.enabled = false;
        wavingCatButton.enabled = false;
        workTableButton.enabled = false;
        grammophoneButton.enabled = false;
        chestButton.enabled = false;
        dogButton.enabled = false;
        statueButton.enabled = false;
        mirrorButton.enabled = false;
    }

    public void EnableButtons()
    {
        poolTableButton.enabled = true;
        armchairButton.enabled = true;
        bookshelfButton.enabled = true;
        plantButton.enabled = true;
        couchButton.enabled = true;
        wavingCatButton.enabled = true;
        workTableButton.enabled = true;
        grammophoneButton.enabled = true;
        chestButton.enabled = true;
        dogButton.enabled = true;
        statueButton.enabled = true;
        mirrorButton.enabled = true;
    }

    public void SetAllStatesToFalse()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        plantButtonClicked = false;
        couchButtonClicked = false;
        wavingCatButtonClicked = false;
        workTableButtonClicked = false;
        grammophoneButtonClicked = false;
        chestButtonClicked = false;
        dogButtonClicked = false;
        statueButtonClicked = false;
        mirrorButtonClicked = false;
        deleteObjectMode = false;
        flipObjectMode = false;
        moveObjectMode = false;
    }
}
