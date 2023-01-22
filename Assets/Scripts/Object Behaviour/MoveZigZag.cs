using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveZigZag : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ZigZag());

    }

    // Update is called once per frame
    void Update()
    {
        moveable.setDirection(transform.up);
        
    }

    private IEnumerator ZigZag()
    {
        while(true)
        {
            transform.Rotate(0f, 0f, 45f, Space.Self);
            yield return new WaitForSeconds(2);
            
            transform.Rotate(0f, 0f, -45f, Space.Self);
            yield return new WaitForSeconds(0.5f);

            transform.Rotate(0f, 0f, -45f, Space.Self);
            yield return new WaitForSeconds(2);

            transform.Rotate(0f, 0f, 45f, Space.Self);
            yield return new WaitForSeconds(0.5f);
        }
            
    }
}
