using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {
	public float _speed;
	public float _turningSpeed;

	public GameObject _bullet;

	Transform _ship;
	// Use this for initialization
	void Start () {
		_ship = this.gameObject.transform.FindChild("Ship").GetComponent<Transform>();
		//Debug.Log(_ship);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate(0,0,-Input.GetAxis("Horizontal") * _turningSpeed);
		this.gameObject.rigidbody2D.velocity = this.gameObject.transform.up * _speed * Input.GetAxis("Vertical");
		_ship.transform.up = transform.position + this.transform.up;
	
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject _gameObject =(GameObject)GameObject.Instantiate(_bullet,this.gameObject.transform.position,new Quaternion(0,0,0,0));
			_gameObject.rigidbody2D.velocity = this.rigidbody2D.velocity * 1.5f;
		}
	}
}
