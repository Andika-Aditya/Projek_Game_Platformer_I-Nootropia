using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightMov : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    bool ispress = false;
    public GameObject Player;
    public float Force;


    // Update is called once per frame
    void Update()
    {
        if (ispress)
        {
            Player.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispress = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispress = true;
    }
}
