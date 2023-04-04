using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Text score;
    public ScoreManager scoreManager;
    private void Start()
    {
        score.text = ("¬аш счет: ") + scoreManager.score.ToString();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
