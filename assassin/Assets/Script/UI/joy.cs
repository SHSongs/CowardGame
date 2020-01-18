using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joy : MonoBehaviour
{
    private int speed = 1;
    
    public bool up;

    public bool right;

    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Onclick()
    {
        Debug.Log("button");
        Vector3 move = new Vector3();

        if (Input.GetMouseButton(0))
        {
            if (up)
            {
                move.y = 1;
            }
            else
            {
                move.y = -1;
            }

            if (right)
            {
                move.x = 1;
            }
            else
            {
                move.x = -1;
            }
        }

        move += player.transform.position;
        player.transform.position = move;
    }
}
