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
    public GameObject friendMenu;
    public GameObject buildingMode;
    public GameObject hideInventory;
    public GameObject shopMenu;

    public void OpenInventory()
    {
       
        if (inventoryMenu.activeSelf == true)
        {
            inventoryMenu.SetActive(false);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
        }

        else if (inventoryMenu.activeSelf == false)
        {
            booksMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(false);
            friendMenu.SetActive(false);
            inventoryMenu.SetActive(true);
            buildingMode.SetActive(true);
            hideInventory.SetActive(true);
            shopMenu.SetActive(false);
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
            friendMenu.SetActive(false);
            booksMenu.SetActive(true);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
            shopMenu.SetActive(false);
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
            friendMenu.SetActive(false);
            profileMenu.SetActive(true);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
            shopMenu.SetActive(false);
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
            friendMenu.SetActive(false);
            minigameMenu.SetActive(true);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
            shopMenu.SetActive(false);
        }
    }

    public void OpenFriendMenu()
    {
        if (friendMenu.activeSelf == true)
        {
            friendMenu.SetActive(false);
        }

        else if (friendMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(false);
            booksMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(false);
            friendMenu.SetActive(true);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
            shopMenu.SetActive(false);
        }
    }

    public void OpenShop()
    {
        if (shopMenu.activeSelf == true)
        {
            shopMenu.SetActive(false);
        }

        else if (shopMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(false);
            booksMenu.SetActive(false);
            profileMenu.SetActive(false);
            minigameMenu.SetActive(false);
            friendMenu.SetActive(false);
            buildingMode.SetActive(false);
            hideInventory.SetActive(false);
            shopMenu.SetActive(true);
        }
    }
}
