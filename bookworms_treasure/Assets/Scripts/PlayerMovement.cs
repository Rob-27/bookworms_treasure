using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 3.0f;

    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("StopMoving", 2, 4);
        InvokeRepeating("Move", 0, 4);
    }

    void Update()
    {
    }

    public void StopMoving()
    {
        rb.linearVelocity = new Vector2(0, 0);
    }

    public void Move()
    {
        Vector2[] possibleDirections = { new Vector2(2, 1), new Vector2(2, -1), new Vector2(-2, 1), new Vector2(-2, -1) };
        int indexNumber = Random.Range(0, 4);
        Vector2 randomDirection = possibleDirections[indexNumber];
        rb.linearVelocity = randomDirection * movementSpeed;
    }
}
