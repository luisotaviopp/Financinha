using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PigController : MonoBehaviour
{
    // UI
   
    public Image life1;
    public Image life2;
    public Image life3;

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
        
        life1.sprite = GetComponent<SpriteRenderer>().sprite;
        life2.sprite = GetComponent<SpriteRenderer>().sprite;
        life3.sprite = GetComponent<SpriteRenderer>().sprite;
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
                    canDMG = false;
                    life--;
                    switch (life)
                    {
                        case 2:
                            life3.enabled = false;
                            return;
                        case 1:
                            life2.enabled = false;
                            return;
                        case 0:
                            life1.enabled = false;
                            GameManager.lose = true;
                            SceneManager.LoadSceneAsync(0);
                            return;

                    }                
               
                }
                GetComponent<SpriteRenderer>().enabled = false;
                gameObject.layer = 12;
            }
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            coin_Game += 100;
            coin_text.text = coin_Game.ToString();
            
            if(coin_Game == 300)
            {
                SceneManager.LoadSceneAsync("Quiz");
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
}
