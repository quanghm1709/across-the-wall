using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
	public List<GameObject> pose;
	public int currentPose;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			foreach(GameObject g in pose)
			{
				g.SetActive(false);
			}
			currentPose++;
			if (currentPose >= pose.Count)
			{
				currentPose = 0;
			}
			pose[currentPose].SetActive(true);
		}
	}
}
