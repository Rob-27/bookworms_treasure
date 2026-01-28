using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ObjectBehaviour : MonoBehaviour, IPointerClickHandler
{
    public static GameObject furnitureParent;
    public static GameObject inventoryMenu;
    public static ObjectPlacing buildingMode;
    public bool isFlipped = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        furnitureParent = GameObject.FindWithTag("FurnitureParent");
        inventoryMenu = GameObject.FindWithTag("BuildingMode");
        buildingMode = inventoryMenu.GetComponent<ObjectPlacing>();
        this.transform.parent = furnitureParent.transform;
        this.transform.localScale = new Vector3 (1, 1, 1);
        this.transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Blocked"))
        {
            Destroy(gameObject);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (buildingMode.deleteObjectMode == true)
        {
           Destroy(gameObject);
        }

        if (buildingMode.flipObjectMode == true && isFlipped == false)
        {
           isFlipped = true;
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }

        else if (buildingMode.flipObjectMode == true && isFlipped == true)
        {
            isFlipped = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
