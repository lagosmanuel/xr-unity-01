using UnityEngine;

public class RotateBillboard : MonoBehaviour
{
    [SerializeField] private Transform head;

    public Vector3 rotationOffset = new Vector3(0, 0, 0);

    void Start()
    {

    }

    void LateUpdate()
    {
        if (head == null) return;

        Vector3 direction = transform.position - head.transform.position;
        direction.y = 0;

        if (direction.sqrMagnitude > 0.0001f)
        {
            transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(rotationOffset);
        }
    }
}
