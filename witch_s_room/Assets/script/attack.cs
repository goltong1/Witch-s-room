using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private int Direction=0;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            Direction = 0;
            attack_normal();

        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            Direction = 1;
            attack_normal();

        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            Direction = 2;
            attack_normal();

        }
        else if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            Direction = 3;
            attack_normal();

        }


    }

    void attack_normal()
    { 
        Direction*
        

    }
}
