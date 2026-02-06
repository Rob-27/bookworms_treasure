using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class OpenChest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private SpriteRenderer spriteRen;

    public Sprite openChestSprite;
    public Sprite closedChestSprite;

    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        spriteRen.sprite = openChestSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        spriteRen.sprite = closedChestSprite;
    }
}
