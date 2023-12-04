using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerExitBehavior : MonoBehaviour
{
    public UnityEvent triggerExitEvent;

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}