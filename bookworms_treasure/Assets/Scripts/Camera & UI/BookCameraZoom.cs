using UnityEngine;
using UnityEngine.InputSystem;

public class BookCameraZoom : MonoBehaviour
{
    InputAction moveAction;

    public float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        transform.Translate(moveValue * speed * Time.deltaTime);
    }

    void LateUpdate()
    {
        float minY = -7.2f;
        float maxY = 6.8f;

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
