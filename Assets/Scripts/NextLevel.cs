using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] AudioSource musicPlayer;

    [SerializeField] List<string> scenes;

    int currScene;

    // Start is called before the first frame update
    void Start()
    {
        currScene = scenes.IndexOf(SceneManager.GetActiveScene().name);

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
            SceneManager.LoadScene(scenes[currScene + 1]);

        }
    }

}
