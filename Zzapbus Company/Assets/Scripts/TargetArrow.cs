using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetArrow : MonoBehaviour
{
    public static Dictionary<GameObject, GameObject> targetArrows = new();
    float width;
    float height;

    public static void Clear()
    {
        foreach(var targetArrow in targetArrows.Values) Destroy(targetArrow);
        targetArrows.Clear();
    }

    public void Target(GameObject sender, GameObject receiver)
    {
        if(targetArrows.ContainsKey(sender))
        {
            Destroy(targetArrows[sender]);
            targetArrows.Remove(sender);
        }

        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        Vector3 vector = sender.transform.position - receiver.transform.position;
        width = vector.x;
        height = 1;

        renderer.size = new Vector2(width, height);
        gameObject.transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg, Vector3.forward);
        gameObject.transform.position = new Vector2((sender.transform.position.x + receiver.transform.position.x) / 2 , (sender.transform.position.y + receiver.transform.position.y) / 2 + 1.5f);

        if (sender.gameObject.tag == "SinnerNode")
        {
            renderer.flipY = true;
            renderer.color = Color.blue;
        }    
        else if (sender.gameObject.tag == "AbnormalityNode")
            renderer.color = Color.red;

        targetArrows.Add(sender, gameObject);
    }
}
