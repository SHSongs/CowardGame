using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomEnemy : MonoBehaviour
{
    private AudioSource _audioSource;
    private Hp _hp;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
        _hp = this.GetComponent<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("enemy"))
        {
            _audioSource.Play();
            _hp.hp -= 10;
            other.enabled = false;
            other.transform.position = new Vector3(0,0,200);
            Destroy(other);
        }

        
        
    }
    
}
