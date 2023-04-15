using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class PlayerController : MonoBehaviour
{

    public Rigidbody2D body;

    public void OnGUI()
    {    // triiger event on trigger key
        if (Event.current.Equals(Event.KeyboardEvent("d")))
        {
            body.velocity += new Vector2(15f, 0);
        }
        if (Event.current.Equals(Event.KeyboardEvent("w")))
        {
            body.velocity += new Vector2(0, 10f);
        }
        if (Event.current.Equals(Event.KeyboardEvent("s")))
        {
            body.velocity += new Vector2(0, -13f);
        }
        if (Event.current.Equals(Event.KeyboardEvent("a")))
        {
            body.velocity += new Vector2(-15f, 0);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnKeyDown(KeyDownEvent ev)
    {
        Debug.Log("KeyDown:" + ev.keyCode);
        Debug.Log("KeyDown:" + ev.character);
        Debug.Log("KeyDown:" + ev.modifiers);
    }

    void OnKeyUp(KeyUpEvent ev)
    {
        Debug.Log("KeyUp:" + ev.keyCode);
        Debug.Log("KeyUp:" + ev.character);
        Debug.Log("KeyUp:" + ev.modifiers);
    }
}
