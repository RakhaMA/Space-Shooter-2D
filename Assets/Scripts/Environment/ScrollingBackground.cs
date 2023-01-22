using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;
    public Transform[] background;
    private Vector3 direction;
    private int A;
    private int B;
    
    void Start()
    {
        A = 0;
        B = Random.Range(1, background.Length);

        background[B].position = background[0].position + new Vector3(0, 10, 0);

        direction = new Vector3(0, -1, 0);
    }

    
    void Update()
    {
        positionUpdate();
        checkPosition();
    }

    private void checkPosition()
    {
        if (background[A].position.y <= -10f)
        {
            A = Random.Range(0, background.Length);
            if (A == B) 
            {
                while(A == B) 
                {
                    A = Random.Range(0, background.Length);
                }
            }
            moveToTop(A);
        }

        if (background[B].position.y <= -10f)
        {
            B = Random.Range(0, background.Length);
            if (A == B) 
            {
                while(A == B) 
                {
                    B = Random.Range(0, background.Length);
                }
            }
            moveToTop(B);
        }
    }

    private void moveToTop(int index)
    {
        if (index == A)
        {
            background[A].position = background[B].position + new Vector3(0, 10, 0);
        } else if (index == 1)
        {
            background[B].position = background[A].position + new Vector3(0, 10, 0);
        } 
        
        
    }

    private void positionUpdate()
    {
        background[A].position += direction * Time.deltaTime * speed;
        background[B].position += direction * Time.deltaTime * speed;
    }
}
