using UnityEngine;
using System.Collections;

public class UnitBehavior : MonoBehaviour {
    
    private float counter = 0;
	public void posSetter (int x,int y) {
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,Mathf.Sin(sinValue));
        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        counter =counter ;
        counter = counter % 20;
         int sinValue = counter * 90;
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Mathf.Sin(sinValue));
    }
}
