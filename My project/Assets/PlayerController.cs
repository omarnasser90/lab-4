using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public KeyCode spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundcheck;
    public float groundraduischeck;
    public LayerMask whatIsground;
    private bool grounded;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(L)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
        

        if(GetComponent<SpriteRenderer>()!=null)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    if (Input.GetKey(R)) 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
        

        if(GetComponent<SpriteRenderer>()!=null)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }
       
       
         if(Input.GetKeyDown(spacebar) && grounded)
        {
        jump(); 
        }

    }

void jump()
{
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpheight);
}

void FixedUpdate()
{
   grounded = Physics2D.OverlapCircle(groundcheck.position,groundraduischeck,whatIsground);
    
}


}


