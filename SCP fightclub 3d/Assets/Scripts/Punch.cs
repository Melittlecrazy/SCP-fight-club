using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public GameObject fist;
    public GameObject kick;
    public bool isPlayer2 = false;
    public bool isPlayer1 = false;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space) && isPlayer1 == true) || (Input.GetKey(KeyCode.E) && isPlayer2 == true))
        {
            fist.SetActive(true);
        }
        else fist.SetActive(false);

        if ((Input.GetKey(KeyCode.RightShift) && isPlayer1 == true) || (Input.GetKey(KeyCode.Q) && isPlayer2 == true))
        {
            kick.SetActive(true);
        }
        else kick.SetActive(false);
    }
}
