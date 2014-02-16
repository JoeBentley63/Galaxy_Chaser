using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public Transform _focus;
	public float _allowanceX;
	public float _allowanceY;
	Vector2 _newLocation;
	bool _gotFocus = false;
	// Use this for initialization
	void Start () {
		this.transform.position = _focus.position;
		this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-1);
		_newLocation = new Vector2(this.transform.position.x,this.transform.position.y);

	}
	
	// Update is called once per frame
	void Update () 
	{
			if(_focus.position.x > this.transform.position.x + _allowanceX)
			{
				_newLocation.x = _focus.position.x - _allowanceX;
			}
			else if(_focus.position.x < this.transform.position.x - _allowanceX)
			{
				_newLocation.x = _focus.position.x + _allowanceX;
			}
			else
			{
				
			}
			
			if(_focus.position.y > this.transform.position.y + _allowanceY)
			{
				_newLocation.y = _focus.position.y - _allowanceY;
			}
			else if(_focus.position.y < this.transform.position.y - _allowanceY)
			{
				_newLocation.y = _focus.position.y + _allowanceY;
			}
			else
			{
				
			}
			this.gameObject.transform.position = new Vector3(_newLocation.x,_newLocation.y,-10);
		}
}
