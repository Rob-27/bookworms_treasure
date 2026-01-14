using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject inventoryMenu;

    public GameObject booksMenu;

    public GameObject profileMenu;

    public GameObject minigameMenu;


    public void OpenInventory()
    {
       
        if (inventoryMenu.activeSelf == true)
        {
            inventoryMenu.SetActive(false);
        }

        else if (inventoryMenu.activeSelf == false)
        {
            booksMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(false);
            inventoryMenu.SetActive(true);
        }
    }

    public void OpenBooksMenu()
    {
        if (booksMenu.activeSelf == true)
        {
            booksMenu.SetActive(false);
        }

        else if (booksMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(false);
            booksMenu.SetActive(true);
        }
    }

    public void OpenProfile()
    {
        if (profileMenu.activeSelf == true)
        {
            profileMenu.SetActive(false);
        }

        else if (profileMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(false);
            booksMenu.SetActive(false);
            minigameMenu.SetActive(false);
            profileMenu.SetActive(true);
        }
    }

    public void OpenMiniGames()
    {
        if (minigameMenu.activeSelf == true)
        {
            minigameMenu.SetActive(false);
        }

        else if (minigameMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(false);
            booksMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(true);
        }
    }
}
