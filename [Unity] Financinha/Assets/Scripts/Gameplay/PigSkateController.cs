using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSkateController : PigController 
{
    public bool isOnGroundBackWheel;
    public bool isOnGroundFrontWheel;
    public float WheelRadius;
    public Transform frontWheel;
    public Transform backWheel;
    public LayerMask groundLayer;
    void Update()
    {
      //  MantendoEquilibrio();
        Jumpp();
        if(!canDMG)
        {
            CanDMGConter();
        }
        
    }
    private void FixedUpdate()
    {
        isOnGroundFrontWheel = Physics2D.OverlapCircle(frontWheel.position, WheelRadius, groundLayer);
        isOnGroundBackWheel = Physics2D.OverlapCircle(backWheel.position, WheelRadius, groundLayer);
        TransitarEntreOsLevels();
    }

    void MantendoEquilibrio()
    {
        if (transform.rotation.z > 0)
        {
            transform.Rotate(0, 0, -1);
        }
        if (transform.rotation.z < 0)
        {
            transform.Rotate(0, 0, 1);
        }
    }
    void Jumpp()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isOnGroundBackWheel && isOnGroundFrontWheel )
            {
                pigRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(backWheel.position, WheelRadius);
        Gizmos.DrawSphere(frontWheel.position, WheelRadius);
    }

   
}
