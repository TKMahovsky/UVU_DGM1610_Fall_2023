using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string playerTag = "Player";
    private int greenItem = 0;
    public AK.Wwise.Event pickupSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            greenItem++;
            Debug.Log("You picked up an item!\nYou now have " + greenItem + "item(s) in your inventory.");
            Destroy(gameObject);
            pickupSound.Post(gameObject);
        }
    }
}
