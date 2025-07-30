using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // Гравець
    public Vector3 offset = new Vector3(0, 15, -15); // Висота і кут
    public float followSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
    }
}
