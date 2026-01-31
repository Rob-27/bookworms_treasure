using UnityEngine;

public class InventoryVisibility : MonoBehaviour
{
    CanvasGroup canvasGroup;

    bool isHidden = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void HideMenu()
    { 
        if (isHidden == false)
        {
            canvasGroup.alpha = 0;
            isHidden = true;
        }

        if (isHidden == true)
        {
            canvasGroup.alpha = 1;
            isHidden = false;
        }
    }
}
