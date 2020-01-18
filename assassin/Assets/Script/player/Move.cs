using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();

        move.x = speed * Input.GetAxis("Horizontal");
        move.y = speed * Input.GetAxis("Vertical");


        this.transform.position += move;
    }

    private void GetAxis(string v)
    {
        throw new NotImplementedException();
    }
}
