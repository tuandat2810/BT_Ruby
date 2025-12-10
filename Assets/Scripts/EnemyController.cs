using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2.5f;
    public bool vertical;

    Rigidbody2D rb;

    int direction = 1;
    float movingTimer;
    public float movingTime = 1.5f;

    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movingTimer = movingTime;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movingTimer -= Time.deltaTime;
        if (movingTimer <= 0f)
        {
            direction = -direction;
            movingTimer = movingTime;
        }

        if (vertical)
        {
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = rb.position;
        if (vertical)
        {
            pos.y += speed * Time.fixedDeltaTime * direction;
        }
        else
        {
            pos.x += speed * Time.fixedDeltaTime * direction;
        }

        rb.MovePosition(pos);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController ruby = collision.gameObject.GetComponent<RubyController>();
        if (ruby != null)
        {
            ruby.ChangeHealth(-5);
            Debug.Log("Enemy hit Ruby!");
        }
    }
}
