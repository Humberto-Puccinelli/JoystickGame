using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float mouseSensitivity = 2f;
    public Transform cameraTransform;

    float xRotation = 0f;
    Vector3 velocity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        // Movimento WASD
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Usa o CharacterController para mover com colisão
        controller.Move(move * speed * Time.deltaTime);
    }
}

