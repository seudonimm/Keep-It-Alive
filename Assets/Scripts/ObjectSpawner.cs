using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] Vector3 worldMousePos;

    //constructs
    [SerializeField] GameObject horizontalObj;
    [SerializeField] GameObject verticalObj;
    [SerializeField] GameObject diagLeftObj;
    [SerializeField] GameObject diagRightObj;
    //construct sprites
    [SerializeField] Sprite horizontal;
    [SerializeField] Sprite vertical;
    [SerializeField] Sprite diagLeft;
    [SerializeField] Sprite diagRight;
    //ui images 
    [SerializeField] Image one;
    [SerializeField] Image two;
    [SerializeField] Image three;
    [SerializeField] Image four;

    [SerializeField] Color notActive;

    [SerializeField] bool canDestroy;

    [SerializeField] Collider2D col;

    [SerializeField] GameObject otherObj;

    [SerializeField] GameObject Destroyer;

    public SelectState selectState;


    // Start is called before the first frame update
    void Start()
    {
        ObjectSelector.objSelected = 1;

        horizontal = horizontalObj.GetComponent<Sprite>();
        vertical = verticalObj.GetComponent<Sprite>();
        diagLeft = diagLeftObj.GetComponent<Sprite>();
        diagRight = diagRightObj.GetComponent<Sprite>();

        notActive = new Color(1,1,1,.5f);

        one.color = Color.white;

        selectState = SelectState.One;

    }

    // Update is called once per frame
    void Update()
    {

        worldMousePos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -2f);

        transform.position = worldMousePos;

        SpawnObjectSetter();

        Selected();

        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }

        if (Input.GetMouseButton(1))
        {
            //Destroy(otherObj);

            Destroyer.SetActive(true);

        }
        else
        {
            Destroyer.SetActive(false);
        }

    }

    void Selected() //switch statement state machine for ui and which object is selected
    {
        switch (selectState)
        {
            case SelectState.One:

                one.color = Color.white;

                if (ObjectSelector.objSelected == 2)
                {
                    one.color = notActive;
                    selectState = SelectState.Two;
                }
                if (ObjectSelector.objSelected == 3)
                {
                    one.color = notActive;
                    selectState = SelectState.Three;
                }
                if (ObjectSelector.objSelected == 4)
                {
                    one.color = notActive;
                    selectState = SelectState.Four;
                }
                break;
            case SelectState.Two:

                two.color = Color.white;

                if (ObjectSelector.objSelected == 1)
                {
                    two.color = notActive;
                    selectState = SelectState.One;
                }
                if (ObjectSelector.objSelected == 3)
                {
                    two.color = notActive;
                    selectState = SelectState.Three;
                }
                if (ObjectSelector.objSelected == 4)
                {
                    two.color = notActive;
                    selectState = SelectState.Four;
                }
                break;
            case SelectState.Three:

                three.color = Color.white;

                if (ObjectSelector.objSelected == 1)
                {
                    three.color = notActive;
                    selectState = SelectState.One;
                }
                if (ObjectSelector.objSelected == 2)
                {
                    three.color = notActive;
                    selectState = SelectState.Two;
                }
                if (ObjectSelector.objSelected == 4)
                {
                    three.color = notActive;
                    selectState = SelectState.Four;
                }
                break;
            case SelectState.Four:

                four.color = Color.white;

                if (ObjectSelector.objSelected == 1)
                {
                    four.color = notActive;
                    selectState = SelectState.One;
                }
                if (ObjectSelector.objSelected == 3)
                {
                    four.color = notActive;
                    selectState = SelectState.Three;
                }
                if (ObjectSelector.objSelected == 2)
                {
                    four.color = notActive;
                    selectState = SelectState.Two;
                }
                break;


        }
    }



    void SpawnObject() //spawn selected object
    {
        //left click
        Input.GetMouseButtonDown(0);

        if(ObjectSelector.objSelected == 1)
        {
            Instantiate(horizontalObj, transform.position, transform.rotation);

            this.GetComponent<SpriteRenderer>().sprite = horizontal;

        }
        if (ObjectSelector.objSelected == 2)
        {
            Instantiate(verticalObj, transform.position, transform.rotation);

            this.GetComponent<SpriteRenderer>().sprite = vertical;


        }


        if (ObjectSelector.objSelected == 4)
        {
            Instantiate(diagLeftObj, transform.position, diagLeftObj.transform.rotation);

            this.GetComponent<SpriteRenderer>().sprite = diagLeft;


        }

        if (ObjectSelector.objSelected == 3)
        {
            Instantiate(diagRightObj, transform.position, diagRightObj.transform.rotation);

            this.GetComponent<SpriteRenderer>().sprite = diagRight;


        }

    }

    void SpawnObjectSetter()//select object to be spawned
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ObjectSelector.objSelected = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ObjectSelector.objSelected = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ObjectSelector.objSelected = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ObjectSelector.objSelected = 4;
        }


    }

}

public enum SelectState
{
    One,
    Two,
    Three,
    Four
}
