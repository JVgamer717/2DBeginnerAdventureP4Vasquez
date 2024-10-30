using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");


    }
    private void FixedUpdate()
    {


        Vector2 position = rigidbody2d.position;
        position.x = position.x + 8.0f * horizontal * Time.deltaTime;
        position.y = position.y + 8.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

}
