using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigBallonController : PigController
{
    
    public float currentTimer;
    public float cooldownTimer;
    public float cooldownTimerFixe;
    private void Update()
    {
        if (blinking_Can)
        {
            Blinking();
        }
        if (!canDMG)
        {
            CanDMGConter();
        }
        Jump();
        TransitarEntreOsLevels();
        if (!canJump)
            currentTimer -= Time.deltaTime;
        {
            if (currentTimer < 0 )
            {
                //Renova o contador
                cooldownTimer = cooldownTimerFixe;
                canJump = true;
                currentTimer = cooldownTimer;
            }
        }
        
    }
    protected void Jump()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            {
                Debug.Log("entrei");
                pigRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                canJump = false;
            }
        }
    }
}
