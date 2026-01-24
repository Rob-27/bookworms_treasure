using UnityEngine;
using UnityEngine.InputSystem;

public class BookCameraZoom : MonoBehaviour
{
    InputAction moveAction;

    public float speed = 10.0f;

    public Camera bookCamera;

    public bool zoomedIn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        if (zoomedIn == true)
        {
            transform.Translate(moveValue * speed * Time.deltaTime);
        }
    }

    void LateUpdate()
    {
        float minY = -7.2f;
        float maxY = 6.8f;

        if (zoomedIn == true)
        {
            transform.position = new Vector3(-100, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }
    }

    public void ZoomCameraIn()
    {
        bookCamera.orthographicSize = 4.5f;
        zoomedIn = true;
    }

    public void ZoomCameraOut()
    {
        bookCamera.orthographicSize = 11.0f;
        zoomedIn = false;
        transform.position = new Vector3(-100, 0, transform.position.z);
    }
}
