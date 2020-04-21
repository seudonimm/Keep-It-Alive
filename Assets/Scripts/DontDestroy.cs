using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<DontDestroy>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        // if more then one music player is in the scene
        //destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "End")
        {
            DontDestroyOnLoad(this.gameObject);
        }

        if (SceneManager.GetActiveScene().name == "End")
        {
            Destroy(this.gameObject);
        }

    }
}
