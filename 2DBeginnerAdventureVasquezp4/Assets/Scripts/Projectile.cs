using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
<<<<<<< HEAD
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2d>();
=======

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
>>>>>>> c2bdbea6d88cdd486f843246ff485be049c615b7
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
>>>>>>> c2bdbea6d88cdd486f843246ff485be049c615b7
    }

    public void Launch(Vector2 direction, float force)
    {
<<<<<<< HEAD

        rigidbody2d.Addforce(direction * force);


=======
        rigidbody2d.AddForce(direction * force);
>>>>>>> c2bdbea6d88cdd486f843246ff485be049c615b7
    }

    void OnCollisionEnter2D(Collision2D other)
    {
<<<<<<< HEAD
        Debug.Log("Projectile Collision with " + other.gameObject);
        Destroy(gameObject);
    }
=======
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Fix();
        }
        
        Destroy(gameObject);
    }

>>>>>>> c2bdbea6d88cdd486f843246ff485be049c615b7
}
