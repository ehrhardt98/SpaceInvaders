using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Alien") {
            SoundManagerScript.PlaySound("enemyDestroyed");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoreScript.scoreValue += 10;
        }
        else if (collision.tag == "Base") {
            Destroy(gameObject);
        }
        else if (collision.tag == "Bullet") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoreScript.scoreValue += 5;
        }
    }
}