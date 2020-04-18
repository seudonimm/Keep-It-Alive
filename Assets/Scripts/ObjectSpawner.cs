using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] Vector3 worldMousePos;

    [SerializeField] GameObject horizontalObj;
    [SerializeField] GameObject verticalObj;
    [SerializeField] GameObject diagLeftObj;
    [SerializeField] GameObject diagRightObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        worldMousePos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, -2f);

        transform.position = worldMousePos;

    }

    void SpawnObject()
    {

    }
}
