using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PigController : MonoBehaviour
{
    
    [SerializeField]private Rigidbody2D pigRb;
    [SerializeField] private Animator pigAnim;
    
    public float jumpForce = 5f;
    public bool isOnGround;
    public int TESTE_PARA_PULAR_FAZES;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        TESTE_PARA_PULAR_FAZES = SceneManager.GetActiveScene().buildIndex;
        pigRb = GetComponent<Rigidbody2D>();
        pigAnim = GetComponent<Animator>();
        Set_LevelAnimation();
        
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

        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("entreei aki");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
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
    private void Set_Animation(bool skate,bool hoverBoard,
                               bool ballonFan,bool ballonJet,
                               bool helicopter,bool jetpack,
                               bool airplane,bool airplaneJet,
                               bool rocket,bool ovni)
    {
        pigAnim.SetBool("Skate", skate);
        pigAnim.SetBool("HoverBoard",hoverBoard);
        pigAnim.SetBool("BallonFan",ballonFan);
        pigAnim.SetBool("BallonJet", ballonJet);
        pigAnim.SetBool("Helicopter", helicopter);
        pigAnim.SetBool("JetPack", jetpack);
        pigAnim.SetBool("Airplane", airplane);
        pigAnim.SetBool("AirplaneJet", airplaneJet);
        pigAnim.SetBool("Rocket", rocket);
        pigAnim.SetBool("Ovni", ovni);
    }
    private void Set_LevelAnimation()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Level 01":
                Set_Animation(true, false, false, false, false, false, false, false, false, false);
                return;
            case "Level 02":
                Set_Animation(false, true, false, false, false, false, false, false, false, false);
                return;
            case "Level 03":
                Set_Animation(false, false, true, false, false, false, false, false, false, false);
                return;
            case "Level 04":
                Set_Animation(false, false, false, true, false, false, false, false, false, false);
                return;
            case "Level 05":
                Set_Animation(false, false, false, false, true, false, false, false, false, false);
                return;
            case "Level 06":
                Set_Animation(false, false, false, false, false, true, false, false, false, false);
                return;
            case "Level 07":
                Set_Animation(false, false, false, false, false, false, true, false, false, false);
                return;
            case "Level 08":
                Set_Animation(false, false, false, false, false, false, false, true, false, false);
                return;
            case "Level 09":
                Set_Animation(false, false, false, false, false, false, false, false, true, false);
                return;
            case "Level 10":
                Set_Animation(false, false, false, false, false, false, false, false, false, true);
                return;

        }
    }
}
