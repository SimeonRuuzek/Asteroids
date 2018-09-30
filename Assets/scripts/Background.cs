using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float _backgroundMovement;
    private float _resetY = -5;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, -_backgroundMovement * Time.deltaTime, 0);
        if (transform.position.y <= _resetY)
        {
            transform.Translate(0, 20, 0);
        }
    }
}
