using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    [SerializeField]
    private float jumpVelo = 10f;
    private Rigidbody2D myBody;
    private Animator anim;
    private SpriteRenderer sprite_renderer;
    private bool isGrounded = true;
    private string GROUND_TAG = "Ground";
    private string walk_animation = "walk";

    private float movementX;
    [SerializeField]
    private float move_force = 10f;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
        sprite_renderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    // note: this is the code for a placeholder sprite (there is no actual sprite at the time of writing this) feel free to put this code somewhere else
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
        Player_movement();
        Player_Animation();

    }

    void Player_movement()
    {
        
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * move_force * Time.deltaTime;


    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            //Debug.Log("Jump pressed");
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpVelo), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            //Debug.Log("hit ground");
            isGrounded = true;
        }
    }

    void Player_Animation()
    {
        if (movementX > 0)
        {
            anim.SetBool(walk_animation, true);
            sprite_renderer.flipX = false;
        }

        else if (movementX < 0)
        {
            anim.SetBool(walk_animation, true);
            sprite_renderer.flipX = true;
        }
        else
        {
            anim.SetBool(walk_animation, false);
        }
    }

  

}
