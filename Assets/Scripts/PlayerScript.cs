using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
     [SerializeField] private Rigidbody2D myRB;
    [SerializeField] private float vel = 5f;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 myVel = new Vector2(horizontal, 0f) * vel;

        myRB.velocity = myVel;
    }
}
