using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterCAmera : MonoBehaviour
{
    private Transform[] playerTrans;//start isn't needed if this is public

    private void Start()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        playerTrans = new Transform[allPlayers.Length];
        for(int i=0; i < allPlayers.Length; i++)
        {
            playerTrans[i] = allPlayers[i].transform;
        }
    }

    public float yOffSet = 2.0f;
    public float minDistance = 7.5f;

    private float xMin, xMax, yMin, yMax;

    private void LateUpdate()
    {
        if (playerTrans.Length == 0)
        {
            
            return;
        }
        xMin = xMax = playerTrans[0].position.x;
        yMin = yMax = playerTrans[0].position.y;
        for(int i=1; i<playerTrans.Length; i++)
        {
            if (playerTrans[i].position.x < xMin)
                xMin = playerTrans[i].position.x;
            if (playerTrans[i].position.x > xMax)
                xMax = playerTrans[i].position.x;
            if (playerTrans[i].position.x < yMin)
                yMin = playerTrans[i].position.y;
            if (playerTrans[i].position.x > yMax)
                yMax = playerTrans[i].position.y;
        }

        float xMid = (xMin + xMax)/2;
        float yMid = (yMin + yMax) / 2;
        float distance = xMax - xMin;
        if (distance < minDistance) distance =minDistance;

        transform.position = new Vector3(xMid, yMid, -minDistance);
    }
}
