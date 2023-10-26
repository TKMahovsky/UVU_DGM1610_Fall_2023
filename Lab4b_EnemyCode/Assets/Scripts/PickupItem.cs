using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameObject GreenPickup;
    public Transform PickupSpawner;
    public Transform Blaster;
    
    void Start()
    {
        //Call SpawnPickup every 6 seconds
        InvokeRepeating("SpawnPickup", 0f, 6f);
    }
    void SpawnPickup()
    {
        Instantiate(GreenPickup, PickupSpawner.transform.position, GreenPickup.transform.rotation);
    }

    void Update()
    {
        if (GreenPickup.transform.position == Blaster.transform.position)
        {
            Destroy(GreenPickup);
        }
    }
}