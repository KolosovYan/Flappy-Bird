using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [SerializeField] private float queueTime = 1.5f;
    private float time = 0;
    [SerializeField] private GameObject pipes;
    [SerializeField] private float height;

    void Update()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(pipes);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }
}
