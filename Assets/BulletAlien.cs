using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAlien : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SoundManagerScript.PlaySound("playerHit");
        }
        else if (collision.tag == "Base") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}