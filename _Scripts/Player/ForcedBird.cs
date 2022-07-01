using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcedBird : MonoBehaviour
{
    Rigidbody rigid;
    //[SerializeField] private float speed = 25.0f;
    [SerializeField] private float forcePower = 500.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Force();
            }
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Force();
                }
            }
        }

    private void Force()
    {

            rigid.AddForce(0, forcePower, 0);

    }
}
