using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public float speed = 0.8f;
    public float speedDown = 0.8f;
    public float wait = 0.6f;
    private bool invert = false;
    public float bulletChance = 0.02f;
    public GameObject bullet;
    public GameObject aliens;

    void Start()
    {
        InvokeRepeating("AliensMove", 0, wait);
    }

    void AliensMove()
    {
        if (invert)
        {
            speed = -speed;
            gameObject.transform.position += Vector3.down * Mathf.Abs(speedDown);
            invert = false;
            speedDown += speedDown * 0.2f + transform.childCount * 0.1f;
            return;
        }
        else
        {
            gameObject.transform.position += Vector3.right * speed;
        }

        foreach (Transform alien in gameObject.transform)
        {
            if (alien.position.x < -8 || alien.position.x > 8)
            {
                invert = true;
                break;
            }

            if (Random.value < bulletChance) {
                Instantiate(bullet, alien.position, alien.rotation);
            }
        }
    }
}
