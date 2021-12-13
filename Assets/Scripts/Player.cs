using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rd;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public Vector2 moveVector;
    public bool is_Right = true;
    public bool is_Left = false;
    public Joystick joystick;
    public Button jump;
    //public Text ScoreText;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        moveVector.x = joystick.Horizontal;
        rd.velocity = new Vector2(moveVector.x * speed, rd.velocity.y);
        //Flip();
        /*if (Input.GetButtonDown("jump"))
            Debug.Log("Jump it!");*/
        Jump();
        /*if (transform.position.x <= -20 || transform.position.y <= -13)
        {
            SceneManager.LoadScene(1);
        }*/

    }
    public float jumpForce = 6f;


    public void Jump()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rd.velocity = new Vector2(rd.velocity.x, jumpForce);
        }*/
    }
    /*void Flip()
    {
        if (!is_Left && is_Right && moveVector.x < 0)
        {
            is_Right = false;
            is_Left = true;
            transform.Rotate(0f, 180f, 0f);
        }
        if (is_Left && !is_Right && moveVector.x > 0)
        {
            is_Right = true;
            is_Left = false;
            transform.Rotate(0f, 180f, 0f);
        }
    }*/
}