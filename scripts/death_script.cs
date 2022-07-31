using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_script : MonoBehaviour
{

    public GameObject startPoint;
    public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        //this should bee seen on  git hub
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
            Debug.Log("deaddeaddeaddead");

        }

    }

}
