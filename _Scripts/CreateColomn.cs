using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateColomn : MonoBehaviour
{
    public GameObject colomn;
    public float coolDown = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateObject", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObject()
    {
        Vector3 pos = Vector3.zero;
        pos.x = 15;
        pos.y = Random.Range(4,10);
        colomn.transform.position = pos;
        Instantiate(colomn);
        pos.y -=14;
        colomn.transform.position = pos;
        Instantiate(colomn);
        Invoke("CreateObject", coolDown);
    }
}
