using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    protected Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {

            pos.x -= speed *Time.fixedDeltaTime;
            transform.position= pos;
        }

        //Debug.Log($"Speed is: {speed}. Speed is: {speed * Time.fixedDeltaTime}, delts: {Time.fixedDeltaTime}");
}
