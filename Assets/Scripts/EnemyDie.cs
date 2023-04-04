using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public int health = 5;

    public GameObject effectDie;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(effectDie, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
