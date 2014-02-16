using UnityEngine;
using System.Collections;

public class FacebookTest : MonoBehaviour {

	private bool isInit = false;

	private void CallFBInit()
	{
		FB.Init(OnInitComplete,OnHideUnity);
	}
	
	private void OnInitComplete()
	{
		Debug.Log("FB.Init completed: Is user logged in? " + FB.IsLoggedIn);
		isInit = true;
	}

	private void OnHideUnity(bool isGameShown)
	{
		Debug.Log("Is game showing? " + isGameShown);
	}

	void OnGUI()
	{
		if(isInit && !FB.IsLoggedIn)
		{
			FB.Login("email,publish_actions",LoggedInFunction);
		}
		if(GUI.Button(new Rect(0,0,100,100),"PRESS ME!!"))
		{
			Debug.Log("Awake");
			CallFBInit();
		}
	}

	void LoggedInFunction(FBResult _result)
	{
		Debug.Log("LoggedIn" + _result.Text);
		FB.Feed(FB.UserId,"www.facebook.com","Testing Facebook SDK","Hey look, i did a thing",":|");
	}

	void Start()
	{

	}
	// Update is called once per frame
	void Update () {
		//Debug.Log("Erry Day!");
	}
}
