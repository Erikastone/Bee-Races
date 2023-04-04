using UnityEngine;

public class Grear : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    public GameObject sound;
    private Animator camAnim;
    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    private void Update()
    {
        transform.Translate(Vector2.left * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camAnim.SetTrigger("Shake");
            Instantiate(sound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<PlayerController>().health -= damage;
            Destroy(gameObject);
        }
    }
}
