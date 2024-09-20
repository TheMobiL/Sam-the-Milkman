using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class laser_shoot : MonoBehaviour
{
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x >= 4) //incredibly scuffed code that doesn't really work properly but this game is a throwaway so it's fine
        {
            Destroy(GameObject.Find("laser(Clone)"), 2);
        }
    }
}
