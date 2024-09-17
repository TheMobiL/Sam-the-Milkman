using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    [SerializeField]
    private float jumpVelo = 4f;
    private Rigidbody2D myBody;
    private bool isGrounded = true;
    private string GROUND_TAG = "Ground";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
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
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Debug.Log("Jump pressed");
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpVelo), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG)) ;
        {
            Debug.Log("hit ground");
            isGrounded = true;
        }
    }
}
