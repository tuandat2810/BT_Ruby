using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectSound;
    // When the player collides with the collectible, increase health and destroy the collectible
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController rubyController = other.GetComponent<RubyController>();
        if (rubyController != null)
        {
            rubyController.ChangeHealth(10);
            if (collectSound != null)
                AudioSource.PlayClipAtPoint(collectSound, Camera.main.transform.position, 1.0f);
            Destroy(gameObject);
        }
        Debug.Log("Health collectible triggered");
    }
}
