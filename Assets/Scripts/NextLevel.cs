using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] AudioSource musicPlayer;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScreen");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            if (SceneManager.GetActiveScene().name == "Level 3")
            {
                SceneManager.LoadScene("Level 4");
            }
            if (SceneManager.GetActiveScene().name == "Level 4")
            {
                SceneManager.LoadScene("End");
            }
            if (SceneManager.GetActiveScene().name == "TestLevel5")
            {
                SceneManager.LoadScene("TestLevel6");
            }
            if (SceneManager.GetActiveScene().name == "TestLevel6")
            {
                SceneManager.LoadScene("End");
            }
        }
    }

}
