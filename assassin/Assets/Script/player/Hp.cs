using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour
{
    public int hp = 100;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public int getHp()
    {
        return hp;
    }
}
