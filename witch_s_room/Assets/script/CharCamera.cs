using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCamera : MonoBehaviour
{
    public GameObject character;
    Vector3 cameraP;
    public float offset_x = 0f;
    public float offset_y = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraP.x = offset_x + character.transform.position.x;
        cameraP.y = offset_y + character.transform.position.y;
        cameraP.z = -10;
        transform.position = cameraP;
    }
}
