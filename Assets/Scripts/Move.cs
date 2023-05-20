using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] public float speed;
    private float HighSpeed = 1;
    private Vector3 firstTouchPosition;
    private float finalTouchX;
    private Vector3 curTouchPosition;
    private float xBound = 2f;
    private float sensitivityMultiplier = 0.01f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movex();
    }
    private void Movex()
    {
        transform.Translate(Vector3.forward * speed * HighSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            curTouchPosition = Input.mousePosition;

            Vector2 touchDelta = (curTouchPosition - firstTouchPosition);

            finalTouchX = (transform.position.x + (touchDelta.x * sensitivityMultiplier));
            finalTouchX = Mathf.Clamp(finalTouchX, -xBound, xBound);

            transform.position = new Vector3(finalTouchX, transform.position.y, transform.position.z);

            firstTouchPosition = Input.mousePosition;
        }





    }
}
