using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PigFinalBehavior : PigController
{
    // Start is called before the first frame update
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
        if (!canJump)
            currentTimer -= Time.deltaTime;
        {
            if (currentTimer < 0)
            {
                //Renova o contador
                cooldownTimer = cooldownTimerFixe;
                canJump = true;
                pigAnim.SetBool("fly", false);
                currentTimer = cooldownTimer;
            }
        }
       
    }
    private void FixedUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject == null)      // Verifica se o toque não está em cima de um botão ou canvas
        {
            int i = 0;
            while (i < Input.touchCount)
            {
                if (Input.GetTouch(i).position.y < Screen.height / 2)
                {
                    if (jumpForce > 0)
                    {
                        jumpForce *= -1;
                    }
                    pigAnim.SetBool("fly", true);
                    pigRb.velocity = new Vector2(0, jumpForce);
                    canJump = false;
                    Debug.Log("entr1e");
                }

                if (Input.GetTouch(i).position.y > Screen.height / 2)
                {
                    if (jumpForce < 0)
                    {
                        jumpForce *= -1;
                    }
                    pigAnim.SetBool("fly", true);
                    pigRb.velocity = new Vector2(0, jumpForce);
                    canJump = false;
                    Debug.Log("entre2");
                }
                ++i;
            }
        }
    }
    protected void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            {

                pigAnim.SetBool("fly", true);
                pigRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                canJump = false;
            }
        }
    }
}
