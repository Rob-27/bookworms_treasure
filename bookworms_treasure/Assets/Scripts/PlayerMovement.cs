using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    //private float walkableHeight = 70;
    //private float walkableWidth = 90;

    private Rigidbody2D rb;

    private float speed = 2.0f;

    public Vector2 startingPosition;
    public Vector2 directionTopRight;
    public Vector2 directionTopLeft;
    public Vector2 directionBottomLeft;
    public Vector2 directionBottomRight;

    private void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
        //startingPosition = new Vector2(0, 0);
    }

    private void OnEnable()
    {
        directionTopRight = new Vector2(2, 1);
        directionBottomRight = new Vector2(2, -1);
        directionTopLeft = new Vector2(-2, 1);
        directionBottomLeft = new Vector2(-2, -1);
    }

    void Update()
    {
        transform.Translate(directionTopLeft * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Obstacle detected");
        }
    }
}
