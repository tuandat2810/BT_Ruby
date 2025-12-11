using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 direction, float force)
    {
        if(rb2d == null) 
        {
             rb2d = GetComponent<Rigidbody2D>();
        }

        rb2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();
        if (enemy != null)
        {
            enemy.Fix();
        }
        Destroy(gameObject);
    }
}
