using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    private Transform player;

    

    // Use this for initialization

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }



    // Update is called once per frame

    void Update()
    {
        float x = player.transform.position.x - this.transform.position.x;
        float y = player.transform.position.y - this.transform.position.y;

        Vector3 vector3;
        
        if (x * y < 100)
        {
            x /= 40;
            y /= 40;
        }
        else if(x * y < 1000)
        {
            x /= 200;
            y /= 200;
        }
        else
        {
            x /= 1000;
            y /= 1000;
        }
        
        vector3 = new Vector3( x, y, 0);
        vector3 += this.transform.position;
        
        this.transform.position = vector3;
    }


}