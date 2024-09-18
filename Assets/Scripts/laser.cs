using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    public GameObject laserPrefab;
    int laserLayer;

    // Start is called before the first frame update
    void Start()
    {
        laserLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        shootLaser();
    }

    void shootLaser()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("shot laser");
            GameObject laser = (GameObject)Instantiate(laserPrefab, transform.position, transform.rotation);
            laser.layer = laserLayer;
        }
    }
}
