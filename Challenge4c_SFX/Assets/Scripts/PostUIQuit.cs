using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostUIQuit : MonoBehaviour
{
    public void OnClick()
    {
        AkSoundEngine.PostEvent("Play_UIQuit", gameObject);
    }
}