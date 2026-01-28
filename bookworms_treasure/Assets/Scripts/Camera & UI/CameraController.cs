using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    InputAction moveAction;

    float speed = 20.0f;

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

    void LateUpdate ()
    {
        int minX = -4;
        int maxX = 12;
        int minY = -14;
        int maxY = 2;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
