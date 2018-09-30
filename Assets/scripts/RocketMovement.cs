using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class RocketMovement : MonoBehaviour {

    public Slider _healthUI;
    public float speed;
    public float minX;
    public float maxX;
    private float _health = 1;


    // Use this for initialization
    void Start ()
    {
        _healthUI.value = _health; 
		
	}
	
	// Update is called once per frame
	void Update () {
        float currentX = transform.position.x;
        if (Input.GetKey(KeyCode.A) && currentX > minX)
            
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D) && currentX <maxX)

        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            

              
        }
        
		

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            _health -= 0.25f;
            _healthUI.value = _health;
            if (_health <= 0.01 )
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
