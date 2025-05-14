using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionEffect; 
    public int scoreAmount = 10; 
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Bullet Collision Detected!");

    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         if (explosionEffect != null)
    //         {
    //             Debug.Log("Explosion Triggered!");

    //             GameObject explosion = Instantiate(explosionEffect, transform.position, Quaternion.identity);

    //             explosion.transform.position = collision.contacts[0].point;

    //             explosion.transform.localScale = new Vector3(10f, 12f, 12f);  

    //             Animator animator = explosion.GetComponent<Animator>();
    //             if (animator != null)
    //             {
    //                 animator.Play("ExplosionAnimationName");  

    //             Destroy(explosion, 2f);
    //         }

    //         if (scoreManager != null)
    //         {
    //             scoreManager.AddScore(scoreAmount);
    //         }

    //         Debug.Log("Enemy Destroyed!");
    //         Destroy(collision.gameObject); 
    //         Destroy(gameObject);           
    //     }
    //     else
    //     {
    //         Destroy(gameObject, 2f);
    //     }
    // }
// }



void OnCollisionEnter(Collision collision)
{
    Debug.Log("Bullet Collision Detected!");

    if (collision.gameObject.CompareTag("Enemy"))
    {
        if (explosionEffect != null)
        {
            Debug.Log("Explosion Triggered!");

            GameObject explosion = Instantiate(explosionEffect, transform.position, Quaternion.identity);

            explosion.transform.position = collision.contacts[0].point;

            explosion.transform.localScale = new Vector3(10f, 12f, 12f);  

            Animator animator = explosion.GetComponent<Animator>();
            if (animator != null)
            {
                animator.Play("ExplosionAnimationName");  
            }

            Destroy(explosion, 2f);
        }

        if (scoreManager != null)
        {
            scoreManager.AddScore(scoreAmount);
        }

        Debug.Log("Enemy Destroyed!");
        Destroy(collision.gameObject); 
        Destroy(gameObject); 
    }
    else
    {
        Destroy(gameObject, 2f);  
    }
}
}
