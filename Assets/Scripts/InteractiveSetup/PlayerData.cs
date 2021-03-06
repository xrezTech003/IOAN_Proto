using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///		CD : PlayerData
///		//this calss is used by OSCPacketBus
///		Construct for the player data, acts more as a struct
/// </summary>
public class PlayerData 
{
	#region PLAYER_VAR
	/// <summary>
	///		VD : active
	/// </summary>
	public bool active;

	/// <summary>
	///		VD : headPos
	/// </summary>
	public Vector3 headPos;

	/// <summary>
	///		VD : headRot
	/// </summary>
	public Quaternion headRot;

	/// <summary>
	///		VD : contPos
	/// </summary>
	public Vector3 contPos;

	/// <summary>
	///		VD : selStarID
	/// </summary>
	public int selStarID;

	/// <summary>
	///		VD : selStarPos
	/// </summary>
	public Vector3 selStarPos;

	/// <summary>
	///		VD : selStarOrigin
	/// </summary>
	public Vector3 selStarOrigin;

	/// <summary>
	///		VD : relStarID
	/// </summary>
	public int relStarID;

	/// <summary>
	///		VD : relStarPos
	/// </summary>
	public Vector3 relStarPos;

	/// <summary>
	///		VD : rayPos
	/// </summary>
	public Vector3 rayPos;

	/// <summary>
	///		VD : ifaceDone
	/// </summary>
	public bool ifaceDone;

	/// <summary>
	///		VD : starHolding
	/// </summary>
	public bool starHolding;

	/// <summary>
	///		VD : starHoldPos
	/// </summary>
	public Vector3 starHoldPos;

	/// <summary>
	///		VD : head
	/// </summary>
	public GameObject head;

	/// <summary>
	///		VD : contR
	/// </summary>
	public GameObject contR;

	/// <summary>
	///		 VD : contL
	/// </summary>
	public GameObject contL;

	/// <summary>
	///		 VD : relStarObj
	/// </summary>
	public GameObject relStarObj;

	/// <summary>
	///		VD : starHoldObj
	/// </summary>
	public GameObject starHoldObj;
    #endregion

    #region PUBLIC_CONSTRUCT
    /**
	<summary>
		CO : PlayerData()
		Set active to false
		Call init()
	</summary>
	**/
    public PlayerData()	
	{
		active = false;
		init ();
	}
    #endregion

    #region PRIVATE_FUNC
    /**
	<summary>
		FD : init()
		initialize all values 
	</summary>
	**/
    private void init()
	{
		headPos = new Vector3 (0, 0, 0);
		headRot = Quaternion.identity;
		contPos = new Vector3 (0, 0, 0);
		selStarID = -1;
		selStarPos = new Vector3 (0, 0, 0);
		selStarOrigin = new Vector3 (0, 0, 0);
		relStarID = -1;
		relStarPos = new Vector3 (0, 0, 0);
		rayPos = new Vector3 (0, 0, 0);
		ifaceDone = false;
		starHolding = false;
		starHoldPos = new Vector3 (0, 0, 0);
		head = null;
		contR = null;
		contL = null;
		relStarObj = null;
		starHoldObj = null;
	}
	#endregion
}
