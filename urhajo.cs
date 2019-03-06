using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urhajo : MonoBehaviour
{
    private Rigidbody2D rb;

    public float maxVelocity = 3;
    public float rotationSpeed = 3;
    public bool s = true;
    public bool e = false;
    public AudioSource audio;

    #region MonoBehaviour API

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

        private void FixedUpdate()
    {
        float yAxic = Input.GetAxis("Vertical");
        float xAxic = Input.GetAxis("Horizontal");

        Tovabbitas(yAxic);
        Rotate(transform, xAxic * rotationSpeed);
    }

    #endregion

     
    #region Maneuvering API

    private void Sebesseg()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
        
    }
     private void Tovabbitas(float osszeg)
    {
        Vector2 ero = transform.up * osszeg;

        rb.AddForce(ero);
    }

    private void Rotate(Transform t, float amount) => t.Rotate(0, 0, amount);
    
    
    private void Zene()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
           
        }
    }
    #endregion
}
