using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject gear;
    private void Start()
    {
        Instantiate(gear, transform.position, Quaternion.identity);
    }
}
