using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // When the player enters the damage zone, decrease health over time
    private void OnTriggerStay2D(Collider2D other)
    {   
        // Wait time interval before applying damage again
        RubyController rubyController = other.GetComponent<RubyController>();
        if (rubyController != null)
        {
            rubyController.ChangeHealth(-5);
        }
        Debug.Log("Damage zone triggered");
    }
}
