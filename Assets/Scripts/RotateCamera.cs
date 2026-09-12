using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float sensitivity = 3f;
    public bool onlyWithRightClick = true;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        rotationY = angles.y;
        rotationX = angles.x;
    }

    void Update()
    {
        bool canRotate = !onlyWithRightClick || Input.GetMouseButton(1);

        if (canRotate)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationY += mouseX;
            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        }
    }
}
