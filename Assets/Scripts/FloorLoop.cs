using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLoop : MonoBehaviour
{
    [SerializeField] private float speed = 0.3f;
    private Material material;
    [SerializeField] private Vector2 offset;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
        StartCoroutine(StartBackgroundLoop());
    }

    private IEnumerator StartBackgroundLoop()
    {
        while (Time.timeScale != 0)
        {
            offset.x += speed * Time.deltaTime;
            material.SetTextureOffset("_MainTex", offset);
            yield return new WaitForEndOfFrame();
        }
    }
}
