using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEvent : MonoBehaviour
{
    public AK.Wwise.Event postEvent;

    // Start is called before the first frame update
    void Start()
    {
        postEvent.Post(gameObject);
    }
}