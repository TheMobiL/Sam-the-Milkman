using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class laser : MonoBehaviour //i was gonna do a bullet but a laser is way easier to see in game
{
    public TextMeshProUGUI ammoText;
    public int ammo = 3;
    public int maxammo = 3;
    public GameObject laserPrefab;
    int laserLayer;
    public string ammoString;

    // Start is called before the first frame update
    void Start()
    {
        laserLayer = gameObject.layer;
        ammoText = FindObjectOfType<TextMeshProUGUI>();
        StartCoroutine(GainAmmo());
    }

    // Update is called once per frame
    void Update()
    {
        shootLaser();
        ammoString = ammo.ToString();
        ammoText.text = ammoString;
    }

    void shootLaser()
    {
        if (Input.GetKeyDown(KeyCode.E) && ammo != 0)
        {
            ammo -= 1;
            //Debug.Log("shot laser, ammo:" + ammo);
            GameObject laser = (GameObject)Instantiate(laserPrefab, transform.position, transform.rotation);
            laser.layer = laserLayer;
        }
    }

    IEnumerator GainAmmo()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            if (ammo < maxammo)
            {
                ammo += 1;
            }
        }
    }
}
