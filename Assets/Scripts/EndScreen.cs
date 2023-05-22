using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] List<Image> cards;

    [SerializeField] float cardTimer, cardTimerMax;

    [SerializeField] int currentEndCard;

    [SerializeField] Text credits, toTitleScreen;

    // Start is called before the first frame update
    void Start()
    {
        credits.enabled = false;
        toTitleScreen.enabled = false;

        cardTimer = cardTimerMax;

        for (int i = 0; i < 7; i++)
        {
            cards[i].enabled = false;
        }

        cards[0].enabled = true;

        currentEndCard = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if(cardTimer <= 0)
        {
            if (currentEndCard < 7)
            {
                cards[currentEndCard].enabled = true;
            }
            currentEndCard++;
            cardTimer = cardTimerMax;
        }
        cardTimer -= Time.deltaTime;


        if(currentEndCard > 7)
        {
            credits.enabled = true;
        }

        if (currentEndCard > 8)
        {
            toTitleScreen.enabled = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }


}

