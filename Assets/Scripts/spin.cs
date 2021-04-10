using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    float spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = Random.Range(30, 60);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, spinSpeed * Time.deltaTime));
    }
}
