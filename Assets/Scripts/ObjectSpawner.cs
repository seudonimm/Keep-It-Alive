using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] Vector3 worldMousePos;

    //constructs

    [SerializeField] List<GameObject> constructs;
    //[SerializeField] List<SpriteRenderer> constructSprites;
    [SerializeField] List<Image> uiImages;


    [SerializeField] Color notActive;

    [SerializeField] bool canDestroy;

    [SerializeField] Collider2D col;

    [SerializeField] GameObject otherObj;

    [SerializeField] GameObject Destroyer;

    public SelectState selectState;


    // Start is called before the first frame update
    void Start()
    {

        notActive = new Color(1,1,1,.5f);

        uiImages[0].color = Color.white;

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

                uiImages[0].color = Color.white;

                if(ObjectSelector.ObjSelect != 0)
                {
                    uiImages[0].color = notActive;
                    selectState = (SelectState)(ObjectSelector.ObjSelect);
                }

                break;
            case SelectState.Two:

                uiImages[1].color = Color.white;

                if (ObjectSelector.ObjSelect != 1)
                {
                    uiImages[1].color = notActive;
                    selectState = (SelectState)(ObjectSelector.ObjSelect);
                }

                break;
            case SelectState.Three:

                uiImages[2].color = Color.white;

                if (ObjectSelector.ObjSelect != 2)
                {
                    uiImages[2].color = notActive;
                    selectState = (SelectState)(ObjectSelector.ObjSelect);
                }

                break;
            case SelectState.Four:

                uiImages[3].color = Color.white;

                if (ObjectSelector.ObjSelect != 3)
                {
                    uiImages[3].color = notActive;
                    selectState = (SelectState)(ObjectSelector.ObjSelect);
                }

                break;


        }
    }



    void SpawnObject() //spawn selected object
    {
        //left click
        Input.GetMouseButtonDown(0);

        Instantiate(constructs[ObjectSelector.ObjSelect], transform.position, constructs[ObjectSelector.ObjSelect].transform.rotation);

    }

    void SpawnObjectSetter()//select object to be spawned
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ObjectSelector.ObjSelect = 0;
            Selected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ObjectSelector.ObjSelect = 1;
            Selected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ObjectSelector.ObjSelect = 2;
            Selected();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ObjectSelector.ObjSelect = 3;
            Selected();
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            ObjectSelector.ObjSelect++;
            ObjectSelector.ObjSelect = Mathf.Clamp(ObjectSelector.ObjSelect, 0, 3);
            Selected();

        }
        if (Input.mouseScrollDelta.y < 0)
        {
            ObjectSelector.ObjSelect--;
            ObjectSelector.ObjSelect = Mathf.Clamp(ObjectSelector.ObjSelect, 0, 3);
            Selected();

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
