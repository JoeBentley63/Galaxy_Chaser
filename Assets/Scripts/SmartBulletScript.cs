using UnityEngine;
using System.Collections;

public class SmartBulletScript : MonoBehaviour {
	
	public float _speed;
	public float _turningSpeed;
	Transform _ship;
	public LayerMask _layerMask;
	public float rayCastDist;
	float _startTime;
	// Use this for initialization
	void Start () {
		_startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - _startTime > 10)
		{
			Destroy(this.gameObject);
		}

		if(Physics2D.Raycast(this.gameObject.transform.position,this.transform.right + this.transform.up,rayCastDist,_layerMask))
		{
			this.transform.Rotate(new Vector3(0,0,_turningSpeed));
			
		}
		if(Physics2D.Raycast(this.gameObject.transform.position,-this.transform.right + this.transform.up,rayCastDist,_layerMask))
		{
			this.transform.Rotate(new Vector3(0,0,-_turningSpeed));
			//Debug.Log("Left");
		}
		this.gameObject.rigidbody2D.velocity = this.gameObject.transform.up * _speed;
		
		//Debug.Log(rigidbody2D.velocity);
		
		
		_ship.transform.up = transform.position + this.transform.up;
		
	}
}