using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float _MinX;
    public float _MaxX;
    public float _spawnY;
    public float _destroyY;
    public float _speedY;
    public float _rotSpeedMin;
    public float _rotSpeedMax;
    private float _rotSpeed;
    public float _MinScale;
    public float _MaxScale;
    private float _Scale;
    public GameObject _explosion; 
   
	void Start () {
        _Scale = Random.Range (_MinScale, _MaxScale);
        _rotSpeed = Random.Range(_rotSpeedMin, _rotSpeedMax);
        _rotSpeed *= Random.Range(0, 2 ) == 1 ? 1 : -1;
    float rndX = Random.Range(_MinX, _MaxX);
        transform.localScale = new Vector3(_Scale, _Scale, 1);
    transform.position = new Vector3(rndX, _spawnY, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 0, _rotSpeed * Time.deltaTime);
        transform.Translate(0, -_speedY * Time.deltaTime, 0, Space.World);
        if (transform.position.y < _destroyY)
        {
            Destroy(gameObject);
   
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if
            ( other.tag == "Player")
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
