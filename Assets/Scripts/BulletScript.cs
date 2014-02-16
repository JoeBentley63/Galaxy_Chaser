using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	float _startTime;
	// Use this for initialization
	void Start () {
		_startTime = Time.time;
	}
	void OnCollisionEnter2D(Collision2D _collision)
	{
		if(_collision.gameObject.layer == LayerMask.NameToLayer("Track"))
		{
			Destroy(this.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if(Time.time - _startTime > 10)
		{
			Destroy(this.gameObject);
		}
	}
}
