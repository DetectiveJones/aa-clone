using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 200f;
    public Rigidbody2D rb;

    void Update ()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "rotator")
        {

            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        } else if (col.tag == "pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
