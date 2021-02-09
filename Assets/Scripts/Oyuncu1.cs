using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu1 : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("VerticalLetters") * movementSpeed);

    }
}
