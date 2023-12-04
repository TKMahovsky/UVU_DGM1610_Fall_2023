using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, disableEvent, enableEvent;
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnEnable()
    {
        enableEvent.Invoke();
    }
}
