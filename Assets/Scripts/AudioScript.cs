using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public static bool MusicControllerCreated = false;

    private void Awake()
    {
        if (!MusicControllerCreated)
        {
            MusicControllerCreated = true;
        }

        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
