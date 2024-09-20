using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro; //disabled score text because it messed with the other ammo text, might add back in a future project

public class laser_hit : MonoBehaviour
{
    //public TextMeshProUGUI scoreText;
    [SerializeField]
    public static int score = 0;
    private string LASER_TAG = "Laser"; //lol
    //public string scoreString;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreString = score.ToString();
        //scoreText.text = scoreString;
    }

    private void OnTriggerEnter2D(Collider2D other) //this was originally OnCollisionEnter2D but i couldn't get it working (not sure if it's a unity bug or i'm just dumb)
    {
        if (other.gameObject.CompareTag(LASER_TAG))
        {
            //Debug.Log("enemy hit");
            score += 50;
            Debug.Log("hit, score: " + score);
            Destroy(this.gameObject);

        }
    }
}
