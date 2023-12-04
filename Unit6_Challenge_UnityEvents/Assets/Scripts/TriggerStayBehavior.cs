using UnityEngine;
using UnityEngine.Events;

public class TriggerStayBehavior : MonoBehaviour
{
    public UnityEvent triggerStayEvent;

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }
}