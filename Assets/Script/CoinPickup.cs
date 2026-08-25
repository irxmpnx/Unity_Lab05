using UnityEngine;
public class CoinPickup : MonoBehaviour
{
    public int coinValue = 1;
    private bool collected = false;
    void OnTriggerEnter(Collider other)
    {
        if (collected) return;
        if (other.CompareTag("Player"))
        {
            collected = true;
            Debug.Log($"เก็บเหรียญแล้ว! ค่า: {coinValue}");
            Destroy(gameObject);
        }
    }
}