using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecuorScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 moveVelocity = new Vector3(0.3f, 0.0f, 0.3f);
    void Start()
    {
        Vector3 playerPos = new Vector3(-3.0f, +.0f, -4.0f);
        transform.position = playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveVelocity * Time.deltaTime);
    }
}

