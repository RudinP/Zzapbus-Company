using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Transform arrow;

    Vector2 startPoint;
    Vector2 endPoint;

    private void Start()
    {
        arrow = GetComponent<Transform>();
        arrow.localScale = Vector2.zero;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            arrow.position = startPoint;
        }
        if (Input.GetMouseButton(0))
        {
            endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(endPoint);
            arrow.localScale = new Vector2(2, Vector2.Distance(startPoint,endPoint));
            
        }
        /*if (Input.GetMouseButtonUp(0))
        {
            arrow.localScale = Vector2.zero;
            arrow.transform.rotation = Quaternion.Euler(0, 0, 0);
        }*/
    }
}