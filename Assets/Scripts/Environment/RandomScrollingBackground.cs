using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScrollingBackground : MonoBehaviour
{
    public float speed;
    public Transform[] background;
    private Vector3 direction;
    
    void Start()
    {
        direction = new Vector3(0, -1, 0);
    }

    
    void Update()
    {
        positionUpdate();
        checkPosition();
    }

    private void checkPosition()
    {
        if (background[0].position.y <= -10f)
        {
            moveToTop(0);
        }
        if (background[1].position.y <= -10f)
        {
            moveToTop(1);
        }
        if (background[2].position.y <= -10f)
        {
            moveToTop(2);
        }
        if (background[3].position.y <= -10f)
        {
            moveToTop(3);
        }
    }

    private void moveToTop(int index)
    {
        for (int i=0;i<background.Length;i++)
        {
            if (i == index) 
            {
                background[i].position = background[i].position + new Vector3(0, 20, 0);
                
            }
        }



        if (index == 0)
        {
            background[0].position = background[3].position + new Vector3(0, 2, 0);
        } else if (index == 1)
        {
            background[1].position = background[0].position + new Vector3(0, 10, 0);
        } else if (index == 2)
        {
            background[2].position = background [1].position + new Vector3(0, 18, 0);
        } else if (index == 3)
        {
            background[3].position = background [2].position + new Vector3(0, 10, 0);
        }
        
        
    }

    private void positionUpdate()
    {
        background[0].position += direction * Time.deltaTime * speed;
        background[1].position += direction * Time.deltaTime * speed;
        background[2].position += direction * Time.deltaTime * speed;
        background[3].position += direction * Time.deltaTime * speed;
    }
}
