using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{

    bool isDead;

    public Transform playerPos;
    
    void Start()
    {
        isDead = false;
    }

    void Update()
    {
        if(isDead)
        {
            SceneManager.LoadScene(1);
        }

        if(playerPos.position.y < -100)
        {
            isDead = true;
        }
    }
}
