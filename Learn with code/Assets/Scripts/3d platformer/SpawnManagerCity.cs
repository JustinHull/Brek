using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerCity : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatDate = 2f;
    private PlayerControllerCityMan PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerCityMan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(PlayerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }

}

