using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterMovement : MonoBehaviour
{
    float movementSpeed = 2.0f;

    private Rigidbody2D rb;

    public GameObject buildingModeObject;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("StopMoving", 2, 4);
        InvokeRepeating("Move", 0, 4);
    }

    void Update()
    {
        if (buildingModeObject.activeSelf == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        else if (buildingModeObject.activeSelf == false)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

    public void StopMoving()
    {
        rb.linearVelocity = new Vector2(0, 0);
    }

    public void Move()
    {
        Vector2[] possibleDirections = { new Vector2(2, 1), new Vector2(2, -1), new Vector2(-2, 1), new Vector2(-2, -1) };
        int indexNumber = Random.Range(0, 4);
        Vector2 direction = possibleDirections[indexNumber];
        rb.linearVelocity = direction * movementSpeed;

        if (direction == possibleDirections[0] || direction == possibleDirections[1])
        {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }

        else if (direction == possibleDirections[2] || direction == possibleDirections[3])
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
