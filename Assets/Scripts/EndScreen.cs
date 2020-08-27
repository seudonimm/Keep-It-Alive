using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] Image endCard1, endCard2, endCard3, endCard4, endCard5, endCard6, endCard7;
    [SerializeField] List<Image> cards;

    [SerializeField] float cardTimer, cardTimerMax;

    [SerializeField] int it;

    [SerializeField] Text credits, toTitleScreen;

    // Start is called before the first frame update
    void Start()
    {
        credits.enabled = false;
        toTitleScreen.enabled = false;

        cardTimer = cardTimerMax;

        cards.Add(endCard1);
        cards.Add(endCard2);
        cards.Add(endCard3);
        cards.Add(endCard4);
        cards.Add(endCard5);
        cards.Add(endCard6);
        cards.Add(endCard7);

        for (int i = 0; i < 7; i++)
        {
            cards[i].enabled = false;
        }

        cards[0].enabled = true;

        it = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if(cardTimer <= 0)
        {
            if (it < 7)
            {
                cards[it].enabled = true;
            }
            it++;
            cardTimer = cardTimerMax;
        }
        cardTimer -= Time.deltaTime;


        if(it > 7)
        {
            credits.enabled = true;
        }

        if (it > 8)
        {
            toTitleScreen.enabled = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }


}

