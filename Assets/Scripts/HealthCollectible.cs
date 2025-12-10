using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // When the player collides with the collectible, increase health and destroy the collectible
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController rubyController = other.GetComponent<RubyController>();
        if (rubyController != null)
        {
            rubyController.ChangeHealth(10);
            Destroy(gameObject);
        }
        Debug.Log("Health collectible triggered");
    }
}
