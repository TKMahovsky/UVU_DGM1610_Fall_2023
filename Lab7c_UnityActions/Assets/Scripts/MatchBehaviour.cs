using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainerBehaviour
{
    public UnityEvent matchEvent, matchDelayedEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            yield return new WaitForSeconds(0.01f);
            matchDelayedEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
