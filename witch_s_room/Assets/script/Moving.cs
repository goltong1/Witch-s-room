using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Moving : MonoBehaviour
{
    Animator animator;
    public int movespeed;
    public int move;
    public bool move_L= false;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("Moving", move);
        //animator.SetBool("Move_L", move_L);
        if (Input.GetKey(KeyCode.A) == true)
        {
            move_L = true;
            move = 3;
            if (transform.position.x > -14)
            {
                transform.Translate(Vector2.left * movespeed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            move_L = true;
            move = 1;
            if (transform.position.y > -8)
            {
                transform.Translate(Vector2.down * movespeed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            move_L = true;
            move = 2;
            if (transform.position.x < 14)
            {
                transform.Translate(Vector2.right * movespeed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.W) == true)
        {
            move_L = true;
            move = 4;
            if (transform.position.y < 8)
            {
                transform.Translate(Vector2.up * movespeed * Time.deltaTime);
            }
        }
        else
        {
            move_L = false;
        }
    }
}
