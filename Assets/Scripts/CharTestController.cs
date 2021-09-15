using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTestController : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test character");
    }

    // Update is called once per frame
    void Update()
    {
        float inputY = Input.GetAxisRaw("Vertical");
        float inputX = Input.GetAxisRaw("Horizontal");
        float vx = inputX * speed;
        float vy = inputY * speed;

        transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0f);
    }
}
