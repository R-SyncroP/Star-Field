using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTag : MonoBehaviour
{
    string textureName;
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        textureName = star.GetComponent<Renderer>().material.GetTexture("_MainTex").name;
        TextMesh textObject = GetComponent<TextMesh>();
        textObject.text = textureName;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = Camera.main.transform.position;

        transform.LookAt(
            new Vector3(camPos.x, transform.position.y, camPos.z)
            );
    }
}
