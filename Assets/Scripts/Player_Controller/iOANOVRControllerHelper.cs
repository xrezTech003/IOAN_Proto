/************************************************************************************
Copyright : Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.

Licensed under the Oculus Master SDK License Version 1.0 (the "License"); you may not use
the Utilities SDK except in compliance with the License, which is provided at the time of installation
or download, or which otherwise accompanies this software in either electronic or hard copy form.

You may obtain a copy of the License at
https://developer.oculus.com/licenses/oculusmastersdk-1.0/

Unless required by applicable law or agreed to in writing, the Utilities SDK distributed
under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
ANY KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.
************************************************************************************/

using UnityEngine;
using System.Collections;

/// <summary>
/// Simple helper script that conditionally enables rendering of a controller if it is connected.:::  iOAN Modified to have a publicly accessible activeController variable for external reference, also limited number of controllers to iOAN compatible list
/// </summary>
public class iOANOVRControllerHelper : MonoBehaviour
{
	/// <summary>
	/// The root GameObject that represents the Oculus Touch for Quest And RiftS Controller model (Left).
	/// </summary>
	public GameObject m_modelOculusTouchQuestAndRiftSLeftController;

	/// <summary>
	/// The root GameObject that represents the Oculus Touch for Quest And RiftS Controller model (Right).
	/// </summary>
	public GameObject m_modelOculusTouchQuestAndRiftSRightController;

	/// <summary>
	/// The root GameObject that represents the Oculus Touch for Rift Controller model (Left).
	/// </summary>
	public GameObject m_modelOculusTouchRiftLeftController;

	/// <summary>
	/// The root GameObject that represents the Oculus Touch for Rift Controller model (Right).
	/// </summary>
	public GameObject m_modelOculusTouchRiftRightController;

	/// <summary>
	/// The controller that determines whether or not to enable rendering of the controller model.
	/// </summary>
	public OVRInput.Controller m_controller;
	private GameObject _activeController;
	/// <summary>
	/// VD: publicly accessible controller reference so we always track the right one
	/// </summary>
	public GameObject activeController { get { return _activeController; } protected set { _activeController = value; } }
	/// <summary>
	/// VD: List for iterating through types
	/// </summary>
	private GameObject[] controllers;
	//public bool isLeft = false;


	private enum ControllerType
	{
		QuestAndRiftS = 1,
		Rift = 2,
	}

	private ControllerType activeControllerType = ControllerType.Rift;

	private bool m_prevControllerConnected = false;
	private bool m_prevControllerConnectedCached = false;

	void Start()
	{
		controllers = new GameObject[4]{ m_modelOculusTouchQuestAndRiftSLeftController, m_modelOculusTouchQuestAndRiftSRightController, m_modelOculusTouchRiftLeftController, m_modelOculusTouchRiftRightController }; ;

		if (OVRPlugin.GetSystemHeadsetType() > 0)
		{
			OVRPlugin.SystemHeadset headset = OVRPlugin.GetSystemHeadsetType();
			switch (headset)
			{
				case OVRPlugin.SystemHeadset.Rift_CV1:
					activeControllerType = ControllerType.Rift;
					break;
				default:
					activeControllerType = ControllerType.QuestAndRiftS;
					break;
			}


			Debug.LogFormat("OVRControllerHelp: Active controller type: {0} for product {1}", activeControllerType, OVRPlugin.productName);
		}
		else gameObject.SetActive(false);
	}

	void Update()
	{
		gameObject.transform.position = OVRInput.GetLocalControllerPosition(m_controller) - new Vector3(0, .92f, 0);
		gameObject.transform.rotation = OVRInput.GetLocalControllerRotation(m_controller);


		/* HeteroProtoype
		gameObject.transform.localPosition = OVRInput.GetLocalControllerPosition(m_controller);
		gameObject.transform..localRotation = OVRInput.GetLocalControllerRotation(m_controller);
		*/

		bool controllerConnected = OVRInput.IsControllerConnected(m_controller);

		if ((controllerConnected != m_prevControllerConnected) || !m_prevControllerConnectedCached)
		{
			if (activeControllerType == ControllerType.Rift)
			{
				m_modelOculusTouchQuestAndRiftSLeftController.SetActive(false);
				m_modelOculusTouchQuestAndRiftSRightController.SetActive(false);
				m_modelOculusTouchRiftLeftController.SetActive(controllerConnected && (m_controller == OVRInput.Controller.LTouch));
				m_modelOculusTouchRiftRightController.SetActive(controllerConnected && (m_controller == OVRInput.Controller.RTouch));
			}
			else /*if (activeControllerType == ControllerType.QuestAndRiftS)*/
		{
			m_modelOculusTouchQuestAndRiftSLeftController.SetActive(controllerConnected && (m_controller == OVRInput.Controller.LTouch));
				m_modelOculusTouchQuestAndRiftSRightController.SetActive(controllerConnected && (m_controller == OVRInput.Controller.RTouch));
				m_modelOculusTouchRiftLeftController.SetActive(false);
				m_modelOculusTouchRiftRightController.SetActive(false);
			}
			foreach (GameObject controller in controllers)
			{
				if (controller.activeInHierarchy == true) activeController = controller;
			}
			m_prevControllerConnected = controllerConnected;
			m_prevControllerConnectedCached = true;
		}
	}
}
