using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{

    public GameObject floorObject;
    public Material[] materials = new Material[5]; //for 5 materials

    public void changeMaterial(int index)
    {
        if (index >= materials.Length) return; //Checking the material is in the list
        floorObject.GetComponent<MeshRenderer>().material = materials[index];
    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
}
