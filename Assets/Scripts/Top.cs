using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("RandDir", 1f);
    }

    void RandDir()
    {
        float rand = Random.Range(0, 2);

        if(rand < 1) { rb.velocity = new Vector2(1 * movementSpeed, rb.velocity.y); }
        else { rb.velocity = new Vector2(-1 * movementSpeed, rb.velocity.y); }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Oyuncu")
        {
            float rand = Random.Range(-5, 5);
            rb.velocity = new Vector2(rb.velocity.x, rand);
        }

        if(collision.gameObject.tag == "Sol Duvar")
        {
            Skor.oyuncu2Skor += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == "Sağ Duvar")
        {
            Skor.oyuncu2Skor += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
