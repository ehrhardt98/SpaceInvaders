using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public GameObject aliens;
    public GameObject player;
    private void Start() {

    }
    void Update()
    {
        if(player == null)
        {
            gameObject.GetComponent<Text>().text = "Vitória dos Aliens... Pressione R para recomeçar";

            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

        else if(aliens.transform.childCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Próxima fase: pressione R";

            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
}

