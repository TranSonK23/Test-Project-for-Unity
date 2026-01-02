using System.Runtime.Serialization;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f; //Enemy move speed
    [SerializeField] private float distance = 3f;
    private Vector3 startPos;
    private bool moveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float leftBound = startPos.x - distance;
        float rightBound = startPos.x + distance;
        void Flip()
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
        if (moveRight)
        {
            transform.Translate(Vector2.right*speed*Time.deltaTime);
            if (transform.position.x >= rightBound)
            {
                moveRight = false;
                Flip();
            }
        }
        else
        {    
            transform.Translate(Vector2.left*speed*Time.deltaTime);
            if (transform.position.x <= leftBound)
            {
                moveRight = true;
                Flip();
            }
        }

    }
}
