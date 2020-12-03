using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Text opponantHealth;
    public Text yourHealth;
    public GameObject death;
    public bool isPlayer2 = false;
    public bool isPlayer1 = false;

    private float health = 100.0f;
    
    void Start()
    {
        health = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Punch" && isPlayer1 == true) || (other.tag == "Punch" && isPlayer2 == true))
        {
            health = health - 5f;
            opponantHealth.text = "  Health: " + health.ToString() + "  ";
            if (health == 0) death.SetActive(true);
        }

        if ((other.tag == "Kick" && isPlayer1 == true) || (other.tag == "Kick" && isPlayer2 == true))
        {
            health = health - 10f;
            opponantHealth.text = "  Health: " + health.ToString() + "  ";
            if (health == 0) death.SetActive(true);
        }
    }
}
