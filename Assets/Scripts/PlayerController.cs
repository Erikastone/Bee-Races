using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;

    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;

    public GameObject effect;
    public Text healthDisplay;
    public GameObject panel;
    public GameObject[] sounds;
    private Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }
    private void Update()
    {
        healthDisplay.text = health.ToString();
        if (health <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            camAnim.SetTrigger("Shake");
            int rand = Random.Range(0, sounds.Length);

            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            camAnim.SetTrigger("Shake");
            int rand = Random.Range(0, sounds.Length);

            Instantiate(sounds[rand], transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);

        }
    }
}
