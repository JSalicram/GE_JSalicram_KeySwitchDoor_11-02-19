using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    private Rigidbody2D theRigidBody;

    public float maxHorixontalSpeed;

    private float speedMultiplier;

    void Start()
    {
        theRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speedMultiplier = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        theRigidBody.velocity = new Vector2(maxHorixontalSpeed * speedMultiplier, theRigidBody.velocity.y);
    }
}
