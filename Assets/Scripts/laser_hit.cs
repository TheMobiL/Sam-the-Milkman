using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            Debug.Log("enemy hit");
            Destroy(this.gameObject);
            //score_int += 1 // at time of writing this score isn't global idk why
        }
    }
}
