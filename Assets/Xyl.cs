using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xyl : MonoBehaviour
{
    //attributes + UI texts 
    public int speed;
    private Animator animator;
    private Rigidbody2D player;

    private bool facingRight = true;

    // Use this for initialization
    void Start()
    {
        speed = 3;
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Up") || Input.GetButton("Left") || Input.GetButton("Down") || Input.GetButton("Right"))
        {
            animator.SetTrigger("XyliaWalk");
            if (Input.GetButton("Up"))
                player.transform.Translate(0, speed * Time.deltaTime, 0);
            if (Input.GetButton("Down"))
                player.transform.Translate(0, -speed * Time.deltaTime, 0);
            if (Input.GetButton("Left"))
            {
                player.transform.Translate(-speed * Time.deltaTime, 0, 0);
                if (facingRight)
                    Flip();
            }
            if (Input.GetButton("Right"))
            {
                player.transform.Translate(speed * Time.deltaTime, 0, 0);
                if (facingRight == false)
                    Flip();
            }
        }
        else
            animator.SetTrigger("XyliaIdle");

    }
    //flipping directions
    void Flip()
    {
        facingRight = !facingRight;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}