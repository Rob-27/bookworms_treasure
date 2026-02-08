using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ObjectBehaviour : MonoBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject furnitureParent;
    public static GameObject buildingModeObject;
    public static ObjectPlacing buildingMode;
    public bool isFlipped = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        furnitureParent = GameObject.FindWithTag("FurnitureParent");
        buildingModeObject = GameObject.FindWithTag("BuildingMode");
        buildingMode = buildingModeObject.GetComponent<ObjectPlacing>();
        this.transform.parent = furnitureParent.transform;
        this.transform.localScale = new Vector3 (1, 1, 1);
        this.transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Blocked"))
        {
            PlayDeleteSound();
            Destroy(gameObject);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (buildingMode.deleteObjectMode == true)
        {
            PlayDeleteSound();
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

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (buildingMode.moveObjectMode == true)
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (buildingMode.moveObjectMode == true)
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);
    }

    public void PlayDeleteSound()
    {
        GameObject soundObject = GameObject.FindWithTag("DeleteSound");
        AudioSource deleteSound = soundObject.GetComponent<AudioSource>();
        deleteSound.Play();
    }
}
