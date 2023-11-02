using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Collider2D birdCollider;
    Animator animator;
    GameManager gameManager;

    public float jumpForce = 7f;
    public Rigidbody2D rb;
    public static bool itsOk;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        itsOk = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && itsOk)
        {
            rb.velocity =Vector2.up * jumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.up * jumpForce;
        itsOk = false;
        birdCollider.enabled = false;
        animator.SetBool("isDeath", true);
        gameManager.GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="PointZone")
        {
            Score.UpdateScore();
        }
    }
}
