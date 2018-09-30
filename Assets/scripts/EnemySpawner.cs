using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float _delay;
    private float _timer = 0;
    public GameObject[] _Enemies;
	// Use this for initialization
	void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
        _timer = _timer + Time.deltaTime;
        if (_timer >= _delay)
        {
            _timer = 0;
            int rnd = Random.Range(0, _Enemies.Length);
            Instantiate(_Enemies[rnd], Vector3.zero, Quaternion.identity);

        }
	}
}
