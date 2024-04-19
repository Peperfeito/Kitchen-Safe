using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    // set the object color in the inspector
    public Color objectColor;
    Vector3 mousePositionOffset;
    private Vector3 GetMouseWordPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    // highlight the object when the mouse is over it
    private void OnMouseEnter()
    {
        // meke the object transparent(50%), change only the alpha value
        GetComponent<SpriteRenderer>().color = new Color(objectColor.r, objectColor.g, objectColor.b, 0.5f);
    }
    // remove the highlight when the mouse is not over it
    private void OnMouseExit()
    {
        // restore the object color to the same as it was
        GetComponent<SpriteRenderer>().color = objectColor;
    }
    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWordPosition();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWordPosition() + mousePositionOffset;
    }
    private void Start()
    {
        GetComponent<SpriteRenderer>().color = objectColor;
    }
}
