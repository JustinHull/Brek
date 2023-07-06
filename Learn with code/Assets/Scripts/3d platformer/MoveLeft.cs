using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerControllerCityMan PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerCityMan>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }  
    }
}
