using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bullet = 20;
    public Text bullettext;
    public Text timer;
    public float timerText = 30;
    private float timerStart = 30;

    private void Start()
    {
        timer.text = timerText.ToString();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && bullet > 0)
        {
            Shoots();
            bullet -= 1;
            bullettext.text = bullet.ToString();

        }
        else if (bullet < 20)
        {
            Reload();
        }
    }
    void Shoots()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    void Reload()
    {
        timerText -= Time.deltaTime;
        timer.text = Mathf.Round(timerText).ToString();

        if (timerText < 0)
        {
            bullet += 1;
            bullettext.text = bullet.ToString();
            timerText = timerStart;
        }
    }

}
