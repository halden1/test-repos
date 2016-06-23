using UnityEngine;
using System.Collections;

public class UnitBehavior : MonoBehaviour {
    public float sinValue = 0 ;
    private float counter = sinValue;
	public void posSetter (int x,int y) {
        sinValue = 0;
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,Mathf.Sin(sinValue));
        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        counter =0;
        counter = counter % 20;
        sinValue = counter * 90;
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Mathf.Sin(sinValue));
    }
}
