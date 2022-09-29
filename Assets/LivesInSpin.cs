using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesInSpin : MonoBehaviour
{

    GameObject TheCube;
    // Start is called before the first frame update
    void Start()
    {
        TheCube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = new Vector3(0,0.25f,0);
        transform.Rotate(rotate);
    }
}
