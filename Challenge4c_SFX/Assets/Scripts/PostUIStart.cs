using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostUIStart : MonoBehaviour
{
    public void OnClick()
    {
        AkSoundEngine.PostEvent("Play_UIStart", gameObject);
    }
}
