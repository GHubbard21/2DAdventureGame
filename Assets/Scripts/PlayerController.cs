using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D myRigidbody;
    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
    }
    public void OnMove(InputValue moveInput) {
        Vector2 moveVector = moveInput.Get<Vector2>();
        myRigidbody.velocity = moveVector * moveSpeed ;

    }

}
