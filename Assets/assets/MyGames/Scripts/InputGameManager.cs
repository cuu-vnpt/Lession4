using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGameManager : MonoBehaviour
{
    public float speedVertical = 10;
    public float speedHorizontal = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * speedVertical*Time.deltaTime);
        transform.Rotate(0, h * speedHorizontal * Time.deltaTime, 0);
    }
}
