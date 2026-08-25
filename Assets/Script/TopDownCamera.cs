using UnityEngine;
public class TopDownCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 15, -6);
 public float smoothSpeed = 3f;
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position,
       desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target.position);
    }
}
