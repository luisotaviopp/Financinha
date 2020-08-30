using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour
{
    private Rigidbody2D pigRb;
    public float jumpForce = 5f;
    public bool isOnGround;

    private void Start()
    {
        pigRb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {            
            if (isOnGround)
            {
                pigRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);                
            }
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isOnGround = false;
        }
    }
}
