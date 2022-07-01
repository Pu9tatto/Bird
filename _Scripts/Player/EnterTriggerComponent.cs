using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTriggerComponent : MonoBehaviour
{
    [SerializeField] private UnityEvent _action = new UnityEvent();
    private void OnTriggerEnter(Collider other)
    {
        _action?.Invoke();
    }
}
