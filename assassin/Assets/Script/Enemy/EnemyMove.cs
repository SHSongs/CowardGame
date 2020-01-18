using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public bool horizon = true;
    public float speed = 1;
    public float scaleX = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector;
        
        if(horizon)
        {
            vector = new Vector3(speed, 0);
        }
        else
        {
            vector = new Vector3(0, speed);
        }

        this.transform.position += vector;

        int angle = 0;
        if (speed > 0)
        {
            if (horizon)
            {
                angle = -90;
            }
            else
            {
                angle = 0;
            }
        }
        else
        {
            if (horizon)
            {
                angle = 90;
            }
            else
            {
                angle = 180;
            }
        }
        
        this.transform.rotation = Quaternion.Euler(0,0,angle);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            speed *= -1;
            scaleX *= -1;

            Vector3 flip = this.transform.localScale;
            flip.x *= -1;
            this.transform.localScale = flip;
        }
    }
    
}
