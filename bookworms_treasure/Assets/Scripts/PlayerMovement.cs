using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    InputAction moveAction;

    float speed = 10.0f;

    void Start()
    {
      moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
      Vector2 moveValue = moveAction.ReadValue<Vector2>();

      transform.Translate(moveValue * speed * Time.deltaTime);
    }
}
