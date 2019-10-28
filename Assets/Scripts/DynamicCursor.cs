using UnityEngine;
using System.Collections;

public class DynamicCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class SpriteCursor : MonoBehaviour
//{
//    private Camera _camera;
//
//    // Start is called before the first frame update
//    void Start()
//    {
//        _camera = Camera.main;
//        Cursor.visible = false;
//    }
//
//    // Update is called once per frame
//    void OnGUI()
//    {
//        Vector3 point = new Vector3();
//        Event currentEvent = Event.current;
//        Vector2 mousePos = new Vector2();
//
//        // Get the mouse position from Event.
//        // Note that the y position from Event is inverted.
//        mousePos.x = currentEvent.mousePosition.x;
//        mousePos.y = _camera.pixelHeight - currentEvent.mousePosition.y;
//
//        point = _camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, _camera.nearClipPlane));
//
//        transform.position = point;
//        
//        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
//        GUILayout.Label("Screen pixels: " + _camera.pixelWidth + ":" + _camera.pixelHeight, "red");
//        GUILayout.Label("Mouse position: " + mousePos, "red");
//        GUILayout.Label("World position: " + point.ToString("F3"), "red");
//        GUILayout.EndArea();
//    }
//}