using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 3;

    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyDie enemy = hitInfo.GetComponent<EnemyDie>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
