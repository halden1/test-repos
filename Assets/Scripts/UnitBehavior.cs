using UnityEngine;
using System.Collections;

public class UnitBehavior : MonoBehaviour {
    public float sinValue = 0 ;//for height
    private float counter = 0 ;// cycling
	public void posSetter (int x,int y) {
        sinValue = x * 90;
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,Mathf.Sin(sinValue));
        counter = x;
    }
	
	// Update is called once per frame
	void Update () {
        counter = counter + Time.deltaTime * 0.1f;
        counter = counter % 20;
        sinValue = counter * 90;
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Mathf.Sin(sinValue));
    }
}
