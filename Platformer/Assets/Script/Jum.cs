using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jum : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce = 5f; // Lực nhảy
    private Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
     if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
