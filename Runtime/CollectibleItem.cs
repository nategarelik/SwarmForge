using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class CollectibleItem : MonoBehaviour
{
    public static int collectedCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            collectedCount++;
            Debug.Log($"Collected {gameObject.name}! Total collected: {collectedCount}");
            Destroy(gameObject);
        }
    }
}