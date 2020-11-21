using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPowerUpManager : MonoBehaviour
{
    public GameObject[] spawnPoints = new GameObject[199];
    public GameObject movementSpeedPowerUp;
    public GameObject freezePowerUp;
    public GameObject doublePointPowerUp;
    public GameObject teleportPowerUp;
    public GameObject cherryPowerUp;
    public GameObject coin;
    private byte PowerUpCount=0;
    public byte MaxPowerUp;
    public float PowerUpSpawnChance;

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Vector3 newPosition = new Vector3(spawnPoints[i].transform.position.x, spawnPoints[i].transform.position.y + 3, spawnPoints[i].transform.position.z);
            if(!(Random.Range(0,101)<=100-PowerUpSpawnChance) && PowerUpCount < MaxPowerUp)
            {
                switch (Random.Range(0, 5))
                {
                    case 0:
                        Instantiate(movementSpeedPowerUp, newPosition, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(freezePowerUp, newPosition, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(doublePointPowerUp, newPosition, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(teleportPowerUp, newPosition, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(cherryPowerUp, newPosition, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                PowerUpCount++;
            }
            else
            {
                Instantiate(coin, newPosition, Quaternion.identity);
            }
        }
    }
}
