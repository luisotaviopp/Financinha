using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PigController : MonoBehaviour
{
    
    [SerializeField]protected Rigidbody2D pigRb;
    public bool canJump;
    public float jumpForce;
    
    protected void Start()
    {
        pigRb = GetComponent<Rigidbody2D>();   
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

}
