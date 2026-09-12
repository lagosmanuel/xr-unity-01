using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = -Input.GetAxis("Horizontal");
        float moveZ = -Input.GetAxis("Vertical");

        Vector3 direction = transform.right * -moveX + transform.forward * -moveZ;

        transform.position += direction * speed * Time.deltaTime;
    }
}
