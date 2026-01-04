using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject inventoryMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenInventory()
    {
       
        if (inventoryMenu.activeSelf == true)
        {
            inventoryMenu.SetActive(false);
        }

        else if (inventoryMenu.activeSelf == false)
        {
            inventoryMenu.SetActive(true);
        }
    }
}
