﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfScreen : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Alien") {
            SoundManagerScript.PlaySound("playerHit");
            Destroy(player);
        }
    }
}
