using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveOrder : MonoBehaviour
{
    public NavControl navControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseOne();
        }
    }

    void OnMouseOne()
    {
        var point = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(point, out hit))
        {
            Debug.Log(hit.point);
            navControl.target = hit.point;
        }
    }
}
