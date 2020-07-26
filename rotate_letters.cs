using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_letters : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50.00f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
