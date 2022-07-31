using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class jumping_scipt : MonoBehaviour
{

    //https://www.youtube.com/watch?v=nPigL-dIqgE
    //https://www.youtube.com/watch?v=hkaysu1Z-N8
    //movement speed in units per second
    public float speed = 5f;
    private float Move;

    private Rigidbody2D rb;
    public float jump = 500f;
    public bool isJumping;

    public Animator animator;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        animator.SetFloat("speedA", Mathf.Abs(rb.velocity.x));


        Move = Input.GetAxis("Horizontal");


        rb.velocity = new Vector2(speed * Move, rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));

            Debug.Log("Space key was pressed.");
        }

    } 
        
        void OnCollisionEnter2D(Collision2D other)
         {
            if (other.gameObject.CompareTag("Ground"))
            {
                isJumping = false;


            }





         }

        void OnCollisionExit2D(Collision2D other)
        {

            if (other.gameObject.CompareTag("Ground"))
            {
                isJumping = true;
            }


        }







       
    


}
