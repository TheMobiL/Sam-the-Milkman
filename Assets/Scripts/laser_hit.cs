using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_hit : MonoBehaviour
{
    [SerializeField]
    private string LASER_TAG = "Laser";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(LASER_TAG))
        {
            Debug.Log("enemy hit");
            Destroy(this.gameObject);
            //score_int += 1 // at time of writing this score isn't global idk why
        }
    }
}
