using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int currentlv;
	public GameObject selectLv;
	public GameObject win;
	public GameObject lose;
	public BGcontroller bg;

	private void Start()
	{
		Time.timeScale = 0f;
	}
	public void SelectLeve(int level)
	{
		Time.timeScale = 1f;
		currentlv = level;

		bg.currentPose = level;
		foreach(GameObject g in bg.pose)
		{
			g.SetActive(false);
		}

		bg.pose[level].SetActive(true);
		selectLv.SetActive(false);
	}

	public void Reselect()
	{
		SceneManager.LoadScene("SampleScene");
	} 
}
