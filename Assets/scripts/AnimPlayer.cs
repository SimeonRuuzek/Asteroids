using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour {

    public float _delay;
    public Sprite[] _sheet;
    private SpriteRenderer _renderer;
	void Start () {
        _renderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Animation());
	}

    // Update is called once per frame
   
    IEnumerator Animation()
    {
        int index = 0;
        while (index < _sheet.Length)
        {
            _renderer.sprite = _sheet[index];
            index++;
            yield return new WaitForSeconds(_delay);

        }

        Destroy(gameObject);
    }

}
