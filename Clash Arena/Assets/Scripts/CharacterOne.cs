using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOne : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {

        // float moveInput = Input.GetAxis("Horizontal");
        // transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);

		if (Input.GetKey("d") || Input.GetKey("a")) {
            float moveInput = Input.GetAxis("Horizontal");
            transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
		}
    }

    private void Jump()
    {
        
    }
}
