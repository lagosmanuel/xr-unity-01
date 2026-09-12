using UnityEngine;

public class RotateBillboard : MonoBehaviour
{
    private Camera cam;

    public Vector3 rotationOffset = new Vector3(0f, 90f, 0f);

    void Start()
    {
        cam = Camera.main;
    }

    void LateUpdate()
    {
        if (cam == null) return;

        Vector3 direction = transform.position - cam.transform.position;
        direction.y = 0;

        if (direction.sqrMagnitude > 0.0001f)
        {
            transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(rotationOffset);
        }
    }
}
