using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour

{
    public GameObject turtle;
    public GameObject Ball;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        turtle.transform.position = Vector3.MoveTowards(turtle.transform.position, Ball.transform.position, speed);
    }
}
