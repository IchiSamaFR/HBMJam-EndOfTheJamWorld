using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protecteur : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;



    Ray rayMouse;

    Vector3 mousePos;
    RaycastHit hit;

    bool mouvementMouse = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MovementProtecteur();
    }

    void MovementProtecteur()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mouvementMouse)
        {
            this.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }

        if((mousePos.x < minX || mousePos.x > maxX) || (mousePos.y > maxY || mousePos.y < minY ) )
        {
            mouvementMouse = false;
        }
        else
        {
            mouvementMouse = true;
        }
    }
}
