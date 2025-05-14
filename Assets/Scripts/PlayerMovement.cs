using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;

    void Update()
{
    float h = 0f;
    float v = 0f;

    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        v = 1f;
    else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        v = -1f;

    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        h = 1f;
    else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        h = -1f;

    transform.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);
    transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);
}

void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Enemy"))
    {
        FindFirstObjectByType<GameManager>().GameOver(); }
}

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Treasure"))
    {
        FindFirstObjectByType<GameManager>().GameOver(true);
        Destroy(other.gameObject); 
    }
}



}
