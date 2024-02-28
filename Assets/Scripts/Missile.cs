using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 400f;
    private float bounds = 22f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // destroy out of bounds
        if (transform.position.x < -bounds || transform.position.x > bounds || transform.position.z < -bounds || transform.position.z > bounds)
        {
            Destroy(gameObject);
        }
    }
}
