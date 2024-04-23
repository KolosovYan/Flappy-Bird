using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    static public bool IsDead = false;
    [SerializeField] private float velocity = 2f;
    [SerializeField] private Rigidbody2D cashedRigidbody;
    [SerializeField] private SceneController sceneController;
    private int points;

    private void Start()
    {
        StartCoroutine(MovePlayer());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Gate")
        {
            sceneController.AddPoint();
        }
        else
        {
            sceneController.GameOver();
            IsDead = true;
        }
    }

    IEnumerator MovePlayer()
    {
        while (!IsDead)
        {
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0) == true);
            cashedRigidbody.velocity = Vector2.up * velocity;
        }
        yield return null;
    }
}
