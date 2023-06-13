using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{
    Transform arrow;

    Vector2 startPoint;
    Vector2 endPoint;

    int senderIndex = -1;
    int receiverIndex = -1;

    public GraphicRaycaster gr1;
    public GraphicRaycaster gr2;

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

            senderIndex = -1;
            receiverIndex = -1;
            
            var ped = new PointerEventData(null);
            ped.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            gr1.Raycast(ped, results);

            if (results.Count <= 0) return;

            foreach(var result in results)
            {
                if(result.gameObject.tag == "SinnerNode")
                {
                    senderIndex = 4 - result.gameObject.transform.parent.GetSiblingIndex();
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (senderIndex == -1) return;

            endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            arrow.localScale = new Vector2(2, Vector2.Distance(startPoint,endPoint));

            Vector2 vector = endPoint - startPoint;
            transform.rotation = Quaternion.FromToRotation(Vector3.up, vector);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            if(senderIndex == -1) return;

            arrow.localScale = Vector2.zero;
            arrow.transform.rotation = Quaternion.Euler(0, 0, 0);

            var ped = new PointerEventData(null);
            ped.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            gr2.Raycast(ped, results);

            if (results.Count <= 0) return;

            foreach (var result in results)
            {
                if (result.gameObject.tag == "AbnormalityNode")
                {
                    receiverIndex = result.gameObject.transform.parent.parent.GetSiblingIndex();
                }
            }

            if (receiverIndex == -1) return;

            Debug.Log($"{senderIndex}  {receiverIndex}");

            //BattleManager.instance.TargetAbnormality(senderIndex, receiverIndex);
        }
    }
}