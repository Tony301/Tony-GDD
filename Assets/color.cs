using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public GameObject cubeplayer;
    private int x = 0;
    private Renderer cubeRenderer;


    //Create a new cube primitive to set the color on
    //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    private void Start()
    {
         cubeRenderer = cubeplayer.GetComponent<Renderer>();
        StartCoroutine("colorchanger");
    }
    IEnumerator colorchanger()
    {
        
        x = x + 1;
        if (x==0)
        {
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
        if (x == 1)
        {
            cubeRenderer.material.SetColor("_Color", Color.white);
        }
        if (x == 2)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);

        }
        if (x == 3)
        {
            cubeRenderer.material.SetColor("_Color", Color.yellow);
        }
        if (x == 4)
        {
            cubeRenderer.material.SetColor("_Color", Color.blue);
            x = 0;
        }
        
        
        yield return new WaitForSeconds(2);
        StartCoroutine("colorchanger");
    }
   
    //Call SetColor using the shader property name "_Color" and setting the color to red
    


}
