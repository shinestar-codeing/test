using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_script : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //sfhashjarhjsdarjsra
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);

    }
}
