using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D Rig;
    public Vector2 resetPosition;
    int normal = 2; 
    //private int timerPUSPeedBall; 

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        Rig.velocity = speed;
    }

    // Update is called once per frame

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void activatePUSpeedUp (float Magnitude)
    {
        Rig.velocity *= Magnitude;
    }
}
