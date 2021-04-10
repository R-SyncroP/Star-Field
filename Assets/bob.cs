using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour
{

    Vector3 floatY;

    public float FloatStrength;

    // Start is called before the first frame update
    void Start()
    {
        FloatStrength = Random.Range(0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        floatY = transform.position;
        floatY.y += (Mathf.Sin(Time.time + FloatStrength)) * Time.deltaTime * 0.75f;
        transform.position = floatY;
    }
}
