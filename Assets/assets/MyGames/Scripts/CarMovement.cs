using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points;
    private int currentPoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bat dau Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, points[currentPoint].position)<0.3f)
        {
            currentPoint++;
        }
        if(currentPoint>=points.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, Time.deltaTime * speed);
    }
}
