using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateController : MonoBehaviour
{
    public float speed = 10f;
    public Animator animator;
    public KeyCode space;
    public float horizontalMove = 0f;

    Vector2 lastClickedPos;

    bool moving;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        
       
            if (Input.GetKey(KeyCode.Space))
                animator.SetTrigger("Shoot");
            else if (Input.GetKeyUp(KeyCode.Space)) 
            {
                animator.SetTrigger("Idle");
            }
   

        animator.SetFloat("Speed", horizontalMove);
        if (Input.GetMouseButtonDown(1))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            horizontalMove = 1f;
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos,
            step);
        }
        else
        {
            horizontalMove = 0f;
            moving = false;
        }
    }
}