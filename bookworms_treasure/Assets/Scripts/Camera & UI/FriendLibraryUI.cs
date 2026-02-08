using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendLibraryUI : MonoBehaviour
{
    public GameObject booksMenu;
    public GameObject friendMenu;


    public void OpenBooksMenu()
    {
        if (booksMenu.activeSelf == true)
        {
            booksMenu.SetActive(false);
        }

        else if (booksMenu.activeSelf == false)
        {
            friendMenu.SetActive(false);
            booksMenu.SetActive(true);
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
            booksMenu.SetActive(false);
            friendMenu.SetActive(true);
        }
    }

    public void HomeButton()
    {
        booksMenu.SetActive(false);
        friendMenu.SetActive(false);
    }
}
