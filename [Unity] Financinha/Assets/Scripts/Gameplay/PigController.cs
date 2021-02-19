﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PigController : MonoBehaviour
{
    // H U D
    public Sprite coin_On;
    public Sprite coin_Off;
    public HUD coinHud;

    public Sprite life_Grey_Sprite_UI;
    public Sprite life_Sprite_UI;
    public Image life1;
    public Image life2;
    public Image life3;
    public float blinking_Current_time;
    public float blinking_Time;
    public int  blinking_Controler;
    public bool blinking_Can;

    public Text coin_text;
    public float coin_Game;

    [SerializeField]protected Rigidbody2D pigRb;

    public int life;
    public bool canDMG;
    public float currentTime;
    public float time;
   
    public bool canJump;
    public float jumpForce;
    
    protected void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            coinHud.coin[i].sprite = coin_Off;
        }
        life1.sprite = life_Sprite_UI;
        life2.sprite = life_Sprite_UI;
        life3.sprite = life_Sprite_UI;
        pigRb = GetComponent<Rigidbody2D>();
        currentTime = time;
    }
    protected void TransitarEntreOsLevels()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync(0);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if(life > 0)
            {
                if (canDMG)
                {
                    GetComponent<SpriteRenderer>().enabled = false;

                    blinking_Can = true;
                    gameObject.layer = 12;
                    canDMG = false;
                    life--;
                    switch (life)
                    {
                        case 2:
                            life3.sprite = life_Grey_Sprite_UI;
                            return;
                        case 1:
                            life2.sprite = life_Grey_Sprite_UI;
                            return;
                        case 0:
                            life1.sprite = life_Grey_Sprite_UI;
                            GameManager.lose = true;
                            coinHud.OpenLoseMenu();
                            Time.timeScale = 0;
                            return;
                    }
                    
                }
                
            }
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            coin_Game += 100;
            coin_text.text = coin_Game.ToString();
            if(coin_Game == 100)
            {
                coinHud.coin[0].sprite = coin_On;
            }
            if (coin_Game == 200)
            {
                coinHud.coin[1].sprite = coin_On;
            }
            if (coin_Game == 300)
            {
                coinHud.coin[2].sprite = coin_On;
            }
            if (coin_Game == 400)
            {
                coinHud.coin[3].sprite = coin_On;
            }
            if (coin_Game == 500)
            {
                coinHud.coin[4].sprite = coin_On;
                GameManager.win = true;
                Time.timeScale = 0;
                coinHud.OpenWinMenu();
            }
            Destroy(collision.gameObject);
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (life > 0)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                gameObject.layer = 10;               
            }
        }
    }
    public void CanDMGConter()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
           
        {
            
            canDMG = true;
            currentTime = time;
            
        }
    }
    public void Blinking()
    {
        blinking_Current_time -= Time.deltaTime;
        if(blinking_Current_time <= 0)
        {
            Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
            blinking_Controler++;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            if(blinking_Controler == 1)
            {
                Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            if(blinking_Controler == 2)
            {
                Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (blinking_Controler == 3)
            {
                Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            if (blinking_Controler == 4)
            {
                Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (blinking_Controler == 5)
            {
                Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                blinking_Can = false;
                blinking_Controler = 0;
            }
            blinking_Current_time = blinking_Time;
        }
    }
}
