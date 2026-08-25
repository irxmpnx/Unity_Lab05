using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
public class PlaneTilt : MonoBehaviour
{
    public Rigidbody rb;
    public float tiltSpeed = 60f; // องศาต่อวินาทีที่หมุนเข้าหาเป้าหมาย
    public float maxTiltAngle = 25f; // มุมเอียงสูงสุด
    void FixedUpdate()
 {

    float h = Input.GetAxis("Horizontal"); // ลูกศรซ้าย-ขวา
    float v = Input.GetAxis("Vertical"); // ลูกศรข้ึน-ลง
    float targetTiltZ = -h * maxTiltAngle; // ซ้าย-ขวา → หมุนรอบแกน Z
    float targetTiltX = v * maxTiltAngle; // หน้า-หลัง → หมุนรอบแกน X

    Quaternion targetRotation = Quaternion.Euler(targetTiltX, 0f,targetTiltZ);
    Quaternion smoothedRotation = Quaternion.RotateTowards(rb.rotation, targetRotation, tiltSpeed * Time.fixedDeltaTime);
    rb.MoveRotation(smoothedRotation);
    }
}
