using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 0.2f;
    private float bound = 8;
    public GameObject bullet;
    public float wait = 0.3f;
    private float timer = 0;

    Vector2 position;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float dh = Input.GetAxis("Horizontal");
        if (( gameObject.transform.position.x > -bound || dh > 0) &&
            ( gameObject.transform.position.x <  bound || dh < 0))
        {
            gameObject.transform.position += Vector3.right * dh * speed * Time.deltaTime;
        }

        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Fire1"))
        {
            timer = 0;
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            SoundManagerScript.PlaySound("fireLaser");
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.tag == "Alien") {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            SoundManagerScript.PlaySound("playerHit");
        }
    }
}
