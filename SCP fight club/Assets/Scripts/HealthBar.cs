using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Text opponantHealth;
    public Text yourHealth;
    public bool isPlayer2 = false;
    public bool isPlayer1 = false;

    private int health = 100;//change this to a float when working on special movies

    void Start()
    {
        health = 100;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Punch" && isPlayer1 == true)
        {
            health = health - 5;
            opponantHealth.text = "Health: " + health.ToString();
        }

        if (other.tag == "Punch" && isPlayer2 == true)
        {
            health = health - 5;
            ;
        }
    }
}
