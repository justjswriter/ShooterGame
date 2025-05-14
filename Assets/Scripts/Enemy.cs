using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed = 0.5f;
    public float hoverHeight = 2f;
    public float hoverSpeed = 1f; 
    private float initialY;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }

        initialY = transform.position.y; 
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction.y = 0; 
            direction.Normalize();

            transform.position += direction * speed * Time.deltaTime;

            
            float hover = Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;
            transform.position = new Vector3(transform.position.x, initialY + hover, transform.position.z);
        }
    }
}
